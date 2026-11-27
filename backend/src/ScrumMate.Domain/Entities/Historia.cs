using ScrumMate.Domain.Common;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Domain.Entities;

/// <summary>Historia de usuario del backlog. Tabla: historias.</summary>
public class Historia : EntidadBase
{
    private readonly List<CriterioAceptacion> _criterios = new();
    private readonly List<HistorialEstado> _historial = new();

    public Guid ProyectoId { get; private set; }
    public Guid? EpicaId { get; private set; }
    public Guid? SprintId { get; private set; }
    public string Titulo { get; private set; } = string.Empty;
    public string? Descripcion { get; private set; }
    public Prioridad Prioridad { get; private set; } = Prioridad.Media;
    public int? Puntos { get; private set; }
    public EstadoHistoria Estado { get; private set; } = EstadoHistoria.PorHacer;
    public int OrdenBacklog { get; private set; }
    public Guid? AsignadoAId { get; private set; }

    public IReadOnlyCollection<CriterioAceptacion> Criterios => _criterios;
    public IReadOnlyCollection<HistorialEstado> Historial => _historial;

    private Historia() { } // EF Core

    public static Historia Crear(Guid proyectoId, string titulo, string? descripcion, Prioridad prioridad, Guid? epicaId, int ordenBacklog)
    {
        // TODO (Albert)
        throw new NotImplementedException("Historia.Crear");
    }

    public void Actualizar(string titulo, string? descripcion, Prioridad prioridad, Guid? epicaId)
    {
        // TODO (Albert)
        throw new NotImplementedException("Historia.Actualizar");
    }

    /// <summary>RN-04: solo 1, 2, 3, 5, 8, 13 o 21 (ver ReglasNegocio.PuntosPermitidos).</summary>
    public void Estimar(int puntos)
    {
        // TODO (Albert)
        throw new NotImplementedException("Historia.Estimar");
    }

    /// <summary>
    /// RN-07: solo pasa a Hecho desde EnRevision y con todos los criterios cumplidos.
    /// Registra el cambio en el historial (base del burndown).
    /// </summary>
    public void CambiarEstado(EstadoHistoria nuevoEstado, Guid usuarioId)
    {
        // TODO (Albert)
        throw new NotImplementedException("Historia.CambiarEstado");
    }

    public void AsignarA(Guid? usuarioId)
    {
        // TODO (Albert)
        throw new NotImplementedException("Historia.AsignarA");
    }

    public CriterioAceptacion AgregarCriterio(string dado, string cuando, string entonces)
    {
        // TODO (Albert)
        throw new NotImplementedException("Historia.AgregarCriterio");
    }

    public void MoverASprint(Guid sprintId)
    {
        // TODO (Albert): RN-05 – no entra a un sprint sin puntos.
        throw new NotImplementedException("Historia.MoverASprint");
    }

    public void DevolverABacklog()
    {
        // TODO (Albert): SprintId = null y Estado = PorHacer.
        throw new NotImplementedException("Historia.DevolverABacklog");
    }

    public void CambiarOrden(int ordenBacklog)
    {
        // TODO (Albert)
        throw new NotImplementedException("Historia.CambiarOrden");
    }
}
