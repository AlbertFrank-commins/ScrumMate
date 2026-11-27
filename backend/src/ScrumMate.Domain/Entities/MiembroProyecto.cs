using ScrumMate.Domain.Enums;

namespace ScrumMate.Domain.Entities;

/// <summary>Relación usuario–proyecto con su rol. Tabla: miembros_proyecto (PK compuesta).</summary>
public class MiembroProyecto
{
    public Guid ProyectoId { get; private set; }
    public Guid UsuarioId { get; private set; }
    public RolProyecto Rol { get; private set; }
    public DateTime UnidoEn { get; private set; } = DateTime.UtcNow;

    public Usuario? Usuario { get; private set; }

    private MiembroProyecto() { } // EF Core

    public static MiembroProyecto Crear(Guid proyectoId, Guid usuarioId, RolProyecto rol)
    {
        // TODO (Albert)
        throw new NotImplementedException("MiembroProyecto.Crear");
    }

    public void CambiarRol(RolProyecto rol)
    {
        // TODO (Albert)
        throw new NotImplementedException("MiembroProyecto.CambiarRol");
    }
}
