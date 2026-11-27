namespace ScrumMate.Domain.Common;

/// <summary>
/// Se lanza cuando se viola una regla de negocio (RN-01 a RN-10).
/// La API la convierte en HTTP 409 Conflict.
/// </summary>
public sealed class ReglaNegocioException : Exception
{
    /// <summary>Código de la regla, por ejemplo "RN-01".</summary>
    public string Codigo { get; }

    public ReglaNegocioException(string codigo, string mensaje) : base(mensaje)
    {
        Codigo = codigo;
    }
}
