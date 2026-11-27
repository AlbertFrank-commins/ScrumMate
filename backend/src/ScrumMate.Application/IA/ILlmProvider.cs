namespace ScrumMate.Application.IA;

/// <summary>
/// Único contrato para hablar con un modelo de lenguaje.
/// Producción: OllamaProvider (Infrastructure). Pruebas: FakeLlmProvider.
/// </summary>
public interface ILlmProvider
{
    /// <summary>Nombre del modelo en uso, por ejemplo "qwen2.5:3b".</summary>
    string Modelo { get; }

    Task<string> GenerarAsync(LlmPeticion peticion, CancellationToken ct = default);

    IAsyncEnumerable<string> GenerarStreamAsync(LlmPeticion peticion, CancellationToken ct = default);
}

public sealed record LlmMensaje(string Rol, string Contenido);

/// <param name="Mensajes">Conversación: "system", "user", "assistant".</param>
/// <param name="FormatoJson">Si es true se pide al modelo responder en JSON.</param>
public sealed record LlmPeticion(IReadOnlyList<LlmMensaje> Mensajes, bool FormatoJson = true, double Temperatura = 0.3);
