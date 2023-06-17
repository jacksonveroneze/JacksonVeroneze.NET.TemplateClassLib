using JacksonVeroneze.NET.TemplateClassLib.Entities;
using JacksonVeroneze.NET.TemplateClassLib.Models;

namespace JacksonVeroneze.NET.TemplateClassLib.Mappers;

internal static class TemplateMapper
{
    internal static TemplateModel ToModel(
        this TemplateEntity entity)
    {
        return new TemplateModel
        {
            Key = entity.Key,
            Value = entity.Value
        };
    }
}