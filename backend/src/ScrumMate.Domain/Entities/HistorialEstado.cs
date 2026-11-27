using ScrumMate.Domain.Common;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Domain.Entities;

/// <summary>Registro de cada cambio de estado de una historia. Tabla: historial_estados.</summary>
public class HistorialEstado : EntidadBase
{
    public Guid HistoriaId { get; private set; }
    public EstadoHistoria EstadoAnterior { get; private set; }
    public EstadoHistoria EstadoNuevo { get; private set; }
    public Guid UsuarioId { get; private set; }
    public DateTime Fecha { get; private set; } = DateTime.UtcNow;

    private HistorialEstado() { } // EF Core

    public static HistorialEstado Registrar(Guid historiaId, EstadoHistoria anterior, EstadoHistoria nuevo, Guid usuarioId)
    {
        // TODO (Albert)
        throw new NotImplementedException("HistorialEstado.Registrar");
    }
}
