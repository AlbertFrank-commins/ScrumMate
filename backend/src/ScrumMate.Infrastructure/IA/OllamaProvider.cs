using Microsoft.Extensions.Options;
using ScrumMate.Application.IA;

namespace ScrumMate.Infrastructure.IA;

/// <summary>Cliente HTTP de Ollama: POST {BaseUrl}/api/chat.</summary>
public sealed class OllamaProvider : ILlmProvider
{
    private readonly HttpClient _http;
    private readonly OllamaOptions _options;

    public OllamaProvider(HttpClient http, IOptions<OllamaOptions> options)
    {
        _http = http;
        _options = options.Value;
    }

    public string Modelo => _options.Model;

    public Task<string> GenerarAsync(LlmPeticion peticion, CancellationToken ct = default)
    {
        // TODO (Albert): body { model, messages, stream: false, format: "json" si FormatoJson, options: { temperature } }.
        throw new NotImplementedException(nameof(GenerarAsync));
    }

    public IAsyncEnumerable<string> GenerarStreamAsync(LlmPeticion peticion, CancellationToken ct = default)
    {
        // TODO (Albert): stream: true y leer línea por línea (NDJSON) devolviendo message.content.
        throw new NotImplementedException(nameof(GenerarStreamAsync));
    }
}
