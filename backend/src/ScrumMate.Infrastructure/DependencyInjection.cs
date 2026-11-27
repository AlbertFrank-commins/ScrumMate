using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Application.IA;
using ScrumMate.Infrastructure.Auth;
using ScrumMate.Infrastructure.IA;
using ScrumMate.Infrastructure.Persistence;
using ScrumMate.Infrastructure.Persistence.Repositories;

namespace ScrumMate.Infrastructure;

public static class DependencyInjection
{
    /// <summary>Registra base de datos, repositorios, autenticación y proveedor de IA.</summary>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("Default")));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        services.AddScoped<IProyectoRepository, ProyectoRepository>();
        services.AddScoped<IEpicaRepository, EpicaRepository>();
        services.AddScoped<IHistoriaRepository, HistoriaRepository>();
        services.AddScoped<ISprintRepository, SprintRepository>();
        services.AddScoped<IHistorialEstadoRepository, HistorialEstadoRepository>();
        services.AddScoped<ISugerenciaIaRepository, SugerenciaIaRepository>();
        services.AddScoped<DbSeeder>();

        services.Configure<JwtOptions>(configuration.GetSection(JwtOptions.Seccion));
        services.AddSingleton<IJwtService, JwtService>();
        services.AddSingleton<IPasswordHasher, PasswordHasher>();
        services.AddScoped<IAutorizacionProyecto, AutorizacionProyecto>();

        services.Configure<OllamaOptions>(configuration.GetSection(OllamaOptions.Seccion));
        services.AddHttpClient<ILlmProvider, OllamaProvider>();
        services.AddSingleton<IPromptRepository, FilePromptRepository>();

        return services;
    }
}
