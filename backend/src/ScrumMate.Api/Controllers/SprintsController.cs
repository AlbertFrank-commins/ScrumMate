using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ScrumMate.Api.Controllers;

/// <summary>Los controllers no tienen lógica: solo envían el command o query a MediatR.</summary>
[ApiController]
[Authorize]
[Route("api/v1/sprints")]
public sealed class SprintsController : ControllerBase
{
    private readonly ISender _mediator;

    public SprintsController(ISender mediator)
    {
        _mediator = mediator;
    }

    /// <summary>ObtenerSprintQuery. Rol: miembro.</summary>
    [HttpGet("{id:guid}")]
    public Task<IActionResult> Obtener(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Obtener));
    }

    /// <summary>IniciarSprintCommand. Rol: SM (RN-01, RN-03).</summary>
    [HttpPost("{id:guid}/iniciar")]
    public Task<IActionResult> Iniciar(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Iniciar));
    }

    /// <summary>CerrarSprintCommand. Rol: SM (RN-03, RN-06).</summary>
    [HttpPost("{id:guid}/cerrar")]
    public Task<IActionResult> Cerrar(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Cerrar));
    }

    /// <summary>AgregarHistoriaASprintCommand (RN-05).</summary>
    [HttpPost("{id:guid}/historias/{historiaId:guid}")]
    public Task<IActionResult> AgregarHistoria(Guid id, Guid historiaId, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(AgregarHistoria));
    }

    /// <summary>QuitarHistoriaDeSprintCommand.</summary>
    [HttpDelete("{id:guid}/historias/{historiaId:guid}")]
    public Task<IActionResult> QuitarHistoria(Guid id, Guid historiaId, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(QuitarHistoria));
    }

    /// <summary>ObtenerTableroQuery.</summary>
    [HttpGet("{id:guid}/tablero")]
    public Task<IActionResult> ObtenerTablero(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(ObtenerTablero));
    }

    /// <summary>ObtenerBurndownQuery.</summary>
    [HttpGet("{id:guid}/burndown")]
    public Task<IActionResult> ObtenerBurndown(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(ObtenerBurndown));
    }
}
