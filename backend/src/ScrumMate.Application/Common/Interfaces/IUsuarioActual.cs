namespace ScrumMate.Application.Common.Interfaces;

/// <summary>Datos del usuario autenticado, leídos del JWT.</summary>
public interface IUsuarioActual
{
    Guid Id { get; }
    bool EstaAutenticado { get; }
}
