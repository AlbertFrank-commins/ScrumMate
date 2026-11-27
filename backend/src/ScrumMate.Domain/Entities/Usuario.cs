using ScrumMate.Domain.Common;

namespace ScrumMate.Domain.Entities;

/// <summary>Persona registrada en el sistema. Tabla: usuarios.</summary>
public class Usuario : EntidadBase
{
    public string Nombre { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string PasswordHash { get; private set; } = string.Empty;

    private Usuario() { } // EF Core

    /// <summary>Crea un usuario con el hash ya calculado por IPasswordHasher.</summary>
    public static Usuario Crear(string nombre, string email, string passwordHash)
    {
        // TODO (Albert): validar datos, normalizar email a minúsculas y devolver la instancia.
        throw new NotImplementedException("Usuario.Crear");
    }

    public void CambiarNombre(string nombre)
    {
        // TODO (Albert)
        throw new NotImplementedException("Usuario.CambiarNombre");
    }
}
