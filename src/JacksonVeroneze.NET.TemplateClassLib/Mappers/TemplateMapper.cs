using JacksonVeroneze.NET.TemplateClassLib.Models;

namespace JacksonVeroneze.NET.TemplateClassLib.Mappers;

internal static class TemplateMapper
{
    internal static TemplateModel ToModel(
        this Entities.TemplateEntity entity)
    {
        return new TemplateModel()
        {
            Key = entity.Key,
            Value = entity.Value
        };
    }
}