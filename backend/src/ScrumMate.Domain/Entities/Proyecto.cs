using ScrumMate.Domain.Common;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Domain.Entities;

/// <summary>Proyecto Scrum con sus miembros, épicas, historias y sprints. Tabla: proyectos.</summary>
public class Proyecto : EntidadBase
{
    private readonly List<MiembroProyecto> _miembros = new();
    private readonly List<Epica> _epicas = new();
    private readonly List<Sprint> _sprints = new();

    public string Nombre { get; private set; } = string.Empty;
    public string? Descripcion { get; private set; }
    public Guid PropietarioId { get; private set; }

    public IReadOnlyCollection<MiembroProyecto> Miembros => _miembros;
    public IReadOnlyCollection<Epica> Epicas => _epicas;
    public IReadOnlyCollection<Sprint> Sprints => _sprints;

    private Proyecto() { } // EF Core

    /// <summary>Crea el proyecto y agrega al creador como Product Owner.</summary>
    public static Proyecto Crear(string nombre, string? descripcion, Guid propietarioId)
    {
        // TODO (Albert): crear instancia y llamar AgregarMiembro(propietarioId, RolProyecto.ProductOwner).
        throw new NotImplementedException("Proyecto.Crear");
    }

    public void Actualizar(string nombre, string? descripcion)
    {
        // TODO (Albert)
        throw new NotImplementedException("Proyecto.Actualizar");
    }

    public MiembroProyecto AgregarMiembro(Guid usuarioId, RolProyecto rol)
    {
        // TODO (Albert): impedir duplicados.
        throw new NotImplementedException("Proyecto.AgregarMiembro");
    }

    public void CambiarRolMiembro(Guid usuarioId, RolProyecto rol)
    {
        // TODO (Albert): RN-09 si se le quita el rol al único Product Owner.
        throw new NotImplementedException("Proyecto.CambiarRolMiembro");
    }

    public void QuitarMiembro(Guid usuarioId)
    {
        // TODO (Albert): RN-09 – un proyecto siempre tiene al menos un Product Owner.
        throw new NotImplementedException("Proyecto.QuitarMiembro");
    }

    public RolProyecto? ObtenerRol(Guid usuarioId)
    {
        // TODO (Albert): devolver el rol del usuario o null si no es miembro.
        throw new NotImplementedException("Proyecto.ObtenerRol");
    }

    public Sprint? SprintActivo()
    {
        // TODO (Albert): devolver el sprint con Estado == Activo (RN-01: como máximo uno).
        throw new NotImplementedException("Proyecto.SprintActivo");
    }
}
