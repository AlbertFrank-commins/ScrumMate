namespace ScrumMate.Application.Common.Exceptions;

/// <summary>El usuario no tiene el rol necesario. La API responde 403.</summary>
public sealed class ProhibidoException : Exception
{
    public ProhibidoException(string mensaje) : base(mensaje) { }
}
