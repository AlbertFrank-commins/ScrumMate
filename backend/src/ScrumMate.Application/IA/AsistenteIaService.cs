using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Application.IA.Modelos;

namespace ScrumMate.Application.IA;

public sealed class AsistenteIaService : IAsistenteIaService
{
    private readonly ILlmProvider _llm;
    private readonly IPromptRepository _prompts;
    private readonly LlmRespuestaValidator _validador;
    private readonly ISugerenciaIaRepository _sugerencias;
    private readonly IHistoriaRepository _historias;
    private readonly ISprintRepository _sprints;
    private readonly IProyectoRepository _proyectos;
    private readonly IUsuarioActual _usuarioActual;
    private readonly IUnitOfWork _unitOfWork;

    public AsistenteIaService(
        ILlmProvider llm,
        IPromptRepository prompts,
        LlmRespuestaValidator validador,
        ISugerenciaIaRepository sugerencias,
        IHistoriaRepository historias,
        ISprintRepository sprints,
        IProyectoRepository proyectos,
        IUsuarioActual usuarioActual,
        IUnitOfWork unitOfWork)
    {
        _llm = llm;
        _prompts = prompts;
        _validador = validador;
        _sugerencias = sugerencias;
        _historias = historias;
        _sprints = sprints;
        _proyectos = proyectos;
        _usuarioActual = usuarioActual;
        _unitOfWork = unitOfWork;
    }

    public Task<SugerenciaHistoriasDto> GenerarHistoriasAsync(Guid proyectoId, string idea, CancellationToken ct = default)
    {
        // TODO (Albert): prompt "generar-historias.v1" + _llm.GenerarAsync + _validador.Validar<RespuestaHistorias> + guardar SugerenciaIa.
        throw new NotImplementedException(nameof(GenerarHistoriasAsync));
    }

    public Task<SugerenciaCriteriosDto> GenerarCriteriosAsync(Guid historiaId, CancellationToken ct = default)
    {
        // TODO (Albert): prompt "generar-criterios.v1".
        throw new NotImplementedException(nameof(GenerarCriteriosAsync));
    }

    public Task<EstimacionSugeridaDto> SugerirEstimacionAsync(Guid historiaId, CancellationToken ct = default)
    {
        // TODO (Albert): prompt "estimar.v1"; validar que los puntos sean Fibonacci.
        throw new NotImplementedException(nameof(SugerirEstimacionAsync));
    }

    public Task<ResumenSprintDto> ResumirSprintAsync(Guid sprintId, CancellationToken ct = default)
    {
        // TODO (Albert): prompt "resumir-sprint.v1" con meta, fechas e historias del sprint.
        throw new NotImplementedException(nameof(ResumirSprintAsync));
    }

    public IAsyncEnumerable<string> ChatAsync(Guid proyectoId, string pregunta, CancellationToken ct = default)
    {
        // TODO (Albert): prompt "chat-proyecto.v1" + _llm.GenerarStreamAsync (FormatoJson = false).
        throw new NotImplementedException(nameof(ChatAsync));
    }
}
