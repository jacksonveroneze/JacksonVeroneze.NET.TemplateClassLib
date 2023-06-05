using JacksonVeroneze.NET.TemplateClassLib.Models;

namespace JacksonVeroneze.NET.TemplateClassLib.Util.Builders.Models;

[ExcludeFromCodeCoverage]
public static class TemplateModelBuilder
{
    public static TemplateModel BuildSingle()
    {
        return Factory().Generate();
    }

    private static Faker<TemplateModel> Factory()
    {
        return new Faker<TemplateModel>("pt_BR")
            .RuleFor(f => f.Key, s => s.Random.Guid())
            .RuleFor(f => f.Value, s => s.Random.Word());
    }
}