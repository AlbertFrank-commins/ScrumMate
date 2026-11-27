using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ScrumMate.Application.Common.Behaviors;
using ScrumMate.Application.IA;

namespace ScrumMate.Application;

public static class DependencyInjection
{
    /// <summary>Registra MediatR, validadores y servicios de la capa de aplicación.</summary>
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(assembly);
            cfg.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });
        services.AddValidatorsFromAssembly(assembly);
        services.AddScoped<IAsistenteIaService, AsistenteIaService>();
        services.AddSingleton<LlmRespuestaValidator>();
        return services;
    }
}
