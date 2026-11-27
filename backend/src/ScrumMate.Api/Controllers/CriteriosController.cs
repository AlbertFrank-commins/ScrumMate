using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ScrumMate.Application.Features.Kanban;

namespace ScrumMate.Api.Controllers;

/// <summary>Los controllers no tienen lógica: solo envían el command o query a MediatR.</summary>
[ApiController]
[Authorize]
[Route("api/v1/criterios")]
public sealed class CriteriosController : ControllerBase
{
    private readonly ISender _mediator;

    public CriteriosController(ISender mediator)
    {
        _mediator = mediator;
    }

    /// <summary>MarcarCriterioCommand.</summary>
    [HttpPatch("{id:guid}")]
    public Task<IActionResult> Marcar(Guid id, [FromBody] MarcarCriterioCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Marcar));
    }
}
