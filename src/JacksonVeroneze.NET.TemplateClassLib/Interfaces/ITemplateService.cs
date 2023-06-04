using JacksonVeroneze.NET.TemplateClassLib.Models;

namespace JacksonVeroneze.NET.TemplateClassLib.Interfaces;

public interface ITemplateService
{
    Task<TemplateModel?> GetByIdAsync(
        string key,
        CancellationToken cancellationToken = default);
}