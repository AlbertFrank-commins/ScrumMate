using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace ScrumMate.IntegrationTests;

/// <summary>Levanta la API en memoria contra un PostgreSQL de Testcontainers y la IA simulada.</summary>
public sealed class ApiFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        // TODO (Albert): iniciar PostgreSqlContainer, sobrescribir ConnectionStrings:Default
        // y reemplazar ILlmProvider por FakeLlmProvider.
    }
}
