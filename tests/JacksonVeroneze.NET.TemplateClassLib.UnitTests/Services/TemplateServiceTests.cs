using JacksonVeroneze.NET.TemplateClassLib.Models;
using JacksonVeroneze.NET.TemplateClassLib.Services;
using JacksonVeroneze.NET.TemplateClassLib.Util;
using Microsoft.Extensions.Logging;

namespace JacksonVeroneze.NET.TemplateClassLib.UnitTests.Services;

[ExcludeFromCodeCoverage]
public class TemplateServiceTests
{
    private readonly Mock<ILogger<TemplateService>> _mockLogger;

    private readonly TemplateService _service;

    public TemplateServiceTests()
    {
        _mockLogger = new Mock<ILogger<TemplateService>>();

        _mockLogger
            .Setup(mock => mock.IsEnabled(LogLevel.Error))
            .Returns(value: true);

        _mockLogger
            .Setup(mock => mock.IsEnabled(LogLevel.Information))
            .Returns(value: true);

        _service = new TemplateService(
            _mockLogger.Object);
    }

    [Theory(DisplayName = nameof(TemplateService)
                          + nameof(TemplateService.GetByIdAsync)
                          + " : GetByIdAsync - Success")]
    [InlineData(null)]
    [InlineData("")]
    public async Task GetByIdAsync_KeyEmptyOrNull_ThrowArgumentExceptionAsync(
        string? key = null)
    {
        // -------------------------------------------------------
        // Arrange && Act
        // -------------------------------------------------------
        Func<Task> action = () => _service.GetByIdAsync(key!);

        // -------------------------------------------------------
        // Assert
        // -------------------------------------------------------
        await action.Should()
            .ThrowAsync<ArgumentException>()
            .ConfigureAwait(false);

        _mockLogger.Verify("Error", LogLevel.Debug, Times.Never);
    }

    [Fact(DisplayName = nameof(TemplateService)
                        + nameof(TemplateService.GetByIdAsync)
                        + " : GetByIdAsync - Success")]
    public async Task GetByIdAsync_SuccessAsync()
    {
        // -------------------------------------------------------
        // Arrange
        // -------------------------------------------------------
        string key = "key";

        // -------------------------------------------------------
        // Act
        // -------------------------------------------------------
        TemplateModel? result = await _service.GetByIdAsync(key)
            .ConfigureAwait(false);

        // -------------------------------------------------------
        // Assert
        // -------------------------------------------------------
        result.Should()
            .NotBeNull();

        _mockLogger.Verify("Success", LogLevel.Information, Times.Once);
        _mockLogger.Verify("Error", LogLevel.Debug, Times.Never);
    }
}