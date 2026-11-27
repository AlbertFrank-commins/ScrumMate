namespace ScrumMate.Application.Common.Exceptions;

/// <summary>El recurso no existe. La API responde 404.</summary>
public sealed class NoEncontradoException : Exception
{
    public NoEncontradoException(string recurso, object id) : base($"{recurso} '{id}' no existe.") { }
}
