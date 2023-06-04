using JacksonVeroneze.NET.TemplateClassLib.Entities;
using JacksonVeroneze.NET.TemplateClassLib.Extensions;
using JacksonVeroneze.NET.TemplateClassLib.Interfaces;
using JacksonVeroneze.NET.TemplateClassLib.Mappers;
using JacksonVeroneze.NET.TemplateClassLib.Models;

namespace JacksonVeroneze.NET.TemplateClassLib.Services;

internal class TemplateService : ITemplateService
{
    private readonly ILogger<TemplateService> _logger;

    public TemplateService(
        ILogger<TemplateService> logger)
    {
        _logger = logger;
    }

    public Task<TemplateModel?> GetByIdAsync(
        string key,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(key);

        try
        {
            TemplateEntity entity = new()
            {
                Key = Guid.NewGuid(),
                Value = "Value"
            };

            return Task.FromResult(entity.ToModel())!;
        }
        catch (Exception ex)
        {
            _logger.LogGenericError(nameof(TemplateService),
                nameof(GetByIdAsync), ex);

            throw;
        }
    }
}