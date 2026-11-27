using Microsoft.AspNetCore.Authentication.JwtBearer;
using ScrumMate.Api.Middleware;
using ScrumMate.Api.Services;
using ScrumMate.Application;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Infrastructure;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, config) => config
    .ReadFrom.Configuration(context.Configuration)
    .WriteTo.Console());

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<IUsuarioActual, UsuarioActual>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddProblemDetails();

builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        // TODO (Albert): options.TokenValidationParameters con Jwt:Secret, Jwt:Issuer y Jwt:Audience.
    });
builder.Services.AddAuthorization();

// TODO (Albert): agregar chequeo de PostgreSQL y Ollama a /health/ready.
builder.Services.AddHealthChecks();

builder.Services.AddCors(options => options.AddPolicy("web", policy => policy
    .WithOrigins(builder.Configuration["Cors:Origen"] ?? "http://localhost:5173")
    .AllowAnyHeader()
    .AllowAnyMethod()));

var app = builder.Build();

app.UseMiddleware<ManejoErroresMiddleware>();
app.UseSerilogRequestLogging();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("web");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHealthChecks("/health");
app.MapHealthChecks("/health/ready");

// TODO (Albert): en Development, aplicar migraciones y ejecutar DbSeeder.SembrarAsync().

app.Run();

/// <summary>Necesario para WebApplicationFactory en las pruebas de integración.</summary>
public partial class Program { }
