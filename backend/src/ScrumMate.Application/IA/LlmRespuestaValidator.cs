namespace ScrumMate.Application.IA;

/// <summary>
/// Deserializa y valida el JSON devuelto por el modelo. Si falla, el servicio reintenta una vez
/// pidiendo al modelo que corrija el formato.
/// </summary>
public sealed class LlmRespuestaValidator
{
    public T Validar<T>(string json)
    {
        // TODO (Albert): System.Text.Json con PropertyNameCaseInsensitive; lanzar excepción con detalle si no cumple.
        throw new NotImplementedException(nameof(Validar));
    }

    public bool IntentarValidar<T>(string json, out T? resultado, out string? error)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(IntentarValidar));
    }
}
