using JacksonVeroneze.NET.TemplateClassLib.Services;
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
            .Setup(mock => mock.IsEnabled(LogLevel.Debug))
            .Returns(value: true);

        _service = new TemplateService(
            _mockLogger.Object);
    }
}