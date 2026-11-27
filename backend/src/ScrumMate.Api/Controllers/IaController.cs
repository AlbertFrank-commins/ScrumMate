using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ScrumMate.Application.Features.Ia;

namespace ScrumMate.Api.Controllers;

/// <summary>Los controllers no tienen lógica: solo envían el command o query a MediatR.</summary>
[ApiController]
[Authorize]
[Route("api/v1")]
public sealed class IaController : ControllerBase
{
    private readonly ISender _mediator;

    public IaController(ISender mediator)
    {
        _mediator = mediator;
    }

    /// <summary>GenerarHistoriasCommand. Rol: PO.</summary>
    [HttpPost("proyectos/{id:guid}/ia/historias")]
    public Task<IActionResult> GenerarHistorias(Guid id, [FromBody] GenerarHistoriasCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(GenerarHistorias));
    }

    /// <summary>GenerarCriteriosCommand. Rol: PO.</summary>
    [HttpPost("historias/{id:guid}/ia/criterios")]
    public Task<IActionResult> GenerarCriterios(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(GenerarCriterios));
    }

    /// <summary>SugerirEstimacionCommand.</summary>
    [HttpPost("historias/{id:guid}/ia/estimacion")]
    public Task<IActionResult> SugerirEstimacion(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(SugerirEstimacion));
    }

    /// <summary>ResumirSprintCommand.</summary>
    [HttpPost("sprints/{id:guid}/ia/resumen")]
    public Task<IActionResult> ResumirSprint(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(ResumirSprint));
    }

    /// <summary>ChatProyectoCommand con respuesta text/event-stream (SSE): _mediator.CreateStream(...).</summary>
    [HttpPost("proyectos/{id:guid}/ia/chat")]
    public Task<IActionResult> Chat(Guid id, [FromBody] ChatProyectoCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Chat));
    }

    /// <summary>AceptarSugerenciaCommand (RN-10).</summary>
    [HttpPost("ia/sugerencias/{id:guid}/aceptar")]
    public Task<IActionResult> AceptarSugerencia(Guid id, [FromBody] AceptarSugerenciaCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(AceptarSugerencia));
    }
}
