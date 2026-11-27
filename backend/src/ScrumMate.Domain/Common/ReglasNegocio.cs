namespace ScrumMate.Domain.Common;

/// <summary>
/// Catálogo de reglas de negocio. Ver /docs/03-reglas-negocio.md.
/// </summary>
public static class ReglasNegocio
{
    public const string UnSprintActivo = "RN-01";
    public const string SoloPoGestionaBacklog = "RN-02";
    public const string SoloSmGestionaSprints = "RN-03";
    public const string PuntosFibonacci = "RN-04";
    public const string HistoriaSinPuntosNoEntra = "RN-05";
    public const string CierreSprintConRevision = "RN-06";
    public const string HechoDesdeRevisionConCriterios = "RN-07";
    public const string FechasSprintValidas = "RN-08";
    public const string AlMenosUnPo = "RN-09";
    public const string SugerenciaRequiereAceptacion = "RN-10";

    /// <summary>Valores de estimación permitidos (RN-04).</summary>
    public static readonly IReadOnlyList<int> PuntosPermitidos = new[] { 1, 2, 3, 5, 8, 13, 21 };
}
