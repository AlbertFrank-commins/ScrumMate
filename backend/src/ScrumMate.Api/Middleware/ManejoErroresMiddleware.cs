namespace ScrumMate.Api.Middleware;

/// <summary>
/// Convierte excepciones en ProblemDetails:
/// ValidationException → 400, ProhibidoException → 403, NoEncontradoException → 404, ReglaNegocioException → 409.
/// </summary>
public sealed class ManejoErroresMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ManejoErroresMiddleware> _logger;

    public ManejoErroresMiddleware(RequestDelegate next, ILogger<ManejoErroresMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // TODO (Albert): try/catch por tipo de excepción y escribir ProblemDetails con el código correcto.
        await _next(context);
    }
}
