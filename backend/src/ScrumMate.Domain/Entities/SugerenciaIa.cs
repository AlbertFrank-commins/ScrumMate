using ScrumMate.Domain.Common;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Domain.Entities;

/// <summary>
/// Respuesta del LLM guardada para auditoría. RN-10: no se convierte en datos hasta que el usuario la acepta.
/// Tabla: sugerencias_ia (salida_json es jsonb).
/// </summary>
public class SugerenciaIa : EntidadBase
{
    public Guid ProyectoId { get; private set; }
    public Guid UsuarioId { get; private set; }
    public TipoSugerencia Tipo { get; private set; }
    public string Entrada { get; private set; } = string.Empty;
    public string SalidaJson { get; private set; } = "{}";
    public bool? Aceptada { get; private set; }
    public string Modelo { get; private set; } = string.Empty;
    public int DuracionMs { get; private set; }

    private SugerenciaIa() { } // EF Core

    public static SugerenciaIa Crear(Guid proyectoId, Guid usuarioId, TipoSugerencia tipo, string entrada, string salidaJson, string modelo, int duracionMs)
    {
        // TODO (Albert)
        throw new NotImplementedException("SugerenciaIa.Crear");
    }

    /// <summary>Marca la sugerencia como aceptada; opcionalmente con la versión editada por el usuario.</summary>
    public void Aceptar(string? salidaEditadaJson)
    {
        // TODO (Albert)
        throw new NotImplementedException("SugerenciaIa.Aceptar");
    }

    public void Rechazar()
    {
        // TODO (Albert)
        throw new NotImplementedException("SugerenciaIa.Rechazar");
    }
}
