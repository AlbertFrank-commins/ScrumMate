using ScrumMate.Application.IA.Modelos;

namespace ScrumMate.Application.IA;

/// <summary>Orquesta contexto + prompt + LLM + validación + registro de SugerenciaIa.</summary>
public interface IAsistenteIaService
{
    Task<SugerenciaHistoriasDto> GenerarHistoriasAsync(Guid proyectoId, string idea, CancellationToken ct = default);
    Task<SugerenciaCriteriosDto> GenerarCriteriosAsync(Guid historiaId, CancellationToken ct = default);
    Task<EstimacionSugeridaDto> SugerirEstimacionAsync(Guid historiaId, CancellationToken ct = default);
    Task<ResumenSprintDto> ResumirSprintAsync(Guid sprintId, CancellationToken ct = default);
    IAsyncEnumerable<string> ChatAsync(Guid proyectoId, string pregunta, CancellationToken ct = default);
}
