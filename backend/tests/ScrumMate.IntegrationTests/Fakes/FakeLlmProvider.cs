using ScrumMate.Application.IA;

namespace ScrumMate.IntegrationTests.Fakes;

/// <summary>Devuelve respuestas fijas desde Fakes/Respuestas/*.json. Se usa en CI.</summary>
public sealed class FakeLlmProvider : ILlmProvider
{
    public string Modelo => "fake";

    public Task<string> GenerarAsync(LlmPeticion peticion, CancellationToken ct = default)
    {
        // TODO (Albert): elegir el JSON según el prompt recibido.
        throw new NotImplementedException(nameof(GenerarAsync));
    }

    public IAsyncEnumerable<string> GenerarStreamAsync(LlmPeticion peticion, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(GenerarStreamAsync));
    }
}
