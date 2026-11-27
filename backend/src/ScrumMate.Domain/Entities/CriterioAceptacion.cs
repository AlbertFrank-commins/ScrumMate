using ScrumMate.Domain.Common;

namespace ScrumMate.Domain.Entities;

/// <summary>Criterio en formato Dado / Cuando / Entonces. Tabla: criterios_aceptacion.</summary>
public class CriterioAceptacion : EntidadBase
{
    public Guid HistoriaId { get; private set; }
    public string Dado { get; private set; } = string.Empty;
    public string Cuando { get; private set; } = string.Empty;
    public string Entonces { get; private set; } = string.Empty;
    public bool Cumplido { get; private set; }

    private CriterioAceptacion() { } // EF Core

    public static CriterioAceptacion Crear(Guid historiaId, string dado, string cuando, string entonces)
    {
        // TODO (Albert)
        throw new NotImplementedException("CriterioAceptacion.Crear");
    }

    public void MarcarCumplido(bool cumplido)
    {
        // TODO (Albert)
        throw new NotImplementedException("CriterioAceptacion.MarcarCumplido");
    }
}
