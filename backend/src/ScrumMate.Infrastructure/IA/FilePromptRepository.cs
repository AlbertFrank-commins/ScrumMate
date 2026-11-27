using Microsoft.Extensions.Options;
using ScrumMate.Application.IA;

namespace ScrumMate.Infrastructure.IA;

/// <summary>Lee /prompts/&lt;nombre&gt;.md. En Docker la carpeta se copia a /app/prompts.</summary>
public sealed class FilePromptRepository : IPromptRepository
{
    private readonly string _ruta;

    public FilePromptRepository(IOptions<OllamaOptions> options)
    {
        _ruta = options.Value.RutaPrompts;
    }

    public string ObtenerPlantilla(string nombre)
    {
        // TODO (Albert): leer el archivo y quitar la cabecera de metadatos; cachear en memoria.
        throw new NotImplementedException(nameof(ObtenerPlantilla));
    }

    public string Renderizar(string nombre, IReadOnlyDictionary<string, string> variables)
    {
        // TODO (Albert): reemplazar {{clave}} por su valor.
        throw new NotImplementedException(nameof(Renderizar));
    }
}
