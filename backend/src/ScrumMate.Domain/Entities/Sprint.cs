using ScrumMate.Domain.Common;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Domain.Entities;

/// <summary>Iteración de 1 a 4 semanas. Tabla: sprints.</summary>
public class Sprint : EntidadBase
{
    private readonly List<Historia> _historias = new();

    public Guid ProyectoId { get; private set; }
    public string Nombre { get; private set; } = string.Empty;
    public string? Meta { get; private set; }
    public DateOnly FechaInicio { get; private set; }
    public DateOnly FechaFin { get; private set; }
    public EstadoSprint Estado { get; private set; } = EstadoSprint.Planificado;

    public IReadOnlyCollection<Historia> Historias => _historias;

    private Sprint() { } // EF Core

    /// <summary>RN-08: fin posterior al inicio y duración de 1 a 4 semanas.</summary>
    public static Sprint Crear(Guid proyectoId, string nombre, string? meta, DateOnly fechaInicio, DateOnly fechaFin)
    {
        // TODO (Albert)
        throw new NotImplementedException("Sprint.Crear");
    }

    /// <summary>RN-01: no se inicia si el proyecto ya tiene un sprint activo.</summary>
    public void Iniciar(bool existeOtroSprintActivo)
    {
        // TODO (Albert)
        throw new NotImplementedException("Sprint.Iniciar");
    }

    /// <summary>
    /// RN-06: no se cierra con historias EnRevision; las PorHacer y EnProgreso vuelven al backlog.
    /// </summary>
    public void Cerrar()
    {
        // TODO (Albert)
        throw new NotImplementedException("Sprint.Cerrar");
    }

    /// <summary>RN-05: la historia debe tener puntos.</summary>
    public void AgregarHistoria(Historia historia)
    {
        // TODO (Albert)
        throw new NotImplementedException("Sprint.AgregarHistoria");
    }

    public void QuitarHistoria(Historia historia)
    {
        // TODO (Albert)
        throw new NotImplementedException("Sprint.QuitarHistoria");
    }

    public int PuntosComprometidos()
    {
        // TODO (Albert): suma de puntos de las historias del sprint.
        throw new NotImplementedException("Sprint.PuntosComprometidos");
    }

    public int PuntosCompletados()
    {
        // TODO (Albert): suma de puntos de las historias en Hecho.
        throw new NotImplementedException("Sprint.PuntosCompletados");
    }
}
