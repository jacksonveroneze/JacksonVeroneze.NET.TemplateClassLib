using JacksonVeroneze.NET.TemplateClassLib.Configuration;
using JacksonVeroneze.NET.TemplateClassLib.Interfaces;
using JacksonVeroneze.NET.TemplateClassLib.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JacksonVeroneze.NET.TemplateClassLib.Extensions;

[ExcludeFromCodeCoverage]
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddTemplateClassLibService(
        this IServiceCollection services,
        IConfiguration config)
    {
        services.AddScoped<ITemplateService, TemplateService>();

        return services;
    }

    public static IServiceCollection AddTemplateClassLibService(
        this IServiceCollection services,
        Action<TemplateConfiguration> config)
    {
        ArgumentNullException.ThrowIfNull(config);

        TemplateConfiguration conf = new();

        config.Invoke(conf);

        services.AddScoped<ITemplateService, TemplateService>();

        return services;
    }
}