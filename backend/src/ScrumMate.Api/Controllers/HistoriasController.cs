using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ScrumMate.Application.Features.Backlog;
using ScrumMate.Application.Features.Kanban;

namespace ScrumMate.Api.Controllers;

/// <summary>Los controllers no tienen lógica: solo envían el command o query a MediatR.</summary>
[ApiController]
[Authorize]
[Route("api/v1/historias")]
public sealed class HistoriasController : ControllerBase
{
    private readonly ISender _mediator;

    public HistoriasController(ISender mediator)
    {
        _mediator = mediator;
    }

    /// <summary>ObtenerHistoriaQuery. Rol: miembro.</summary>
    [HttpGet("{id:guid}")]
    public Task<IActionResult> Obtener(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Obtener));
    }

    /// <summary>ActualizarHistoriaCommand. Rol: PO.</summary>
    [HttpPut("{id:guid}")]
    public Task<IActionResult> Actualizar(Guid id, [FromBody] ActualizarHistoriaCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Actualizar));
    }

    /// <summary>EliminarHistoriaCommand. Rol: PO.</summary>
    [HttpDelete("{id:guid}")]
    public Task<IActionResult> Eliminar(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Eliminar));
    }

    /// <summary>EstimarHistoriaCommand (RN-04).</summary>
    [HttpPatch("{id:guid}/estimacion")]
    public Task<IActionResult> Estimar(Guid id, [FromBody] EstimarHistoriaCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Estimar));
    }

    /// <summary>CambiarEstadoHistoriaCommand (RN-07).</summary>
    [HttpPatch("{id:guid}/estado")]
    public Task<IActionResult> CambiarEstado(Guid id, [FromBody] CambiarEstadoHistoriaCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(CambiarEstado));
    }

    /// <summary>AsignarHistoriaCommand.</summary>
    [HttpPatch("{id:guid}/asignacion")]
    public Task<IActionResult> Asignar(Guid id, [FromBody] AsignarHistoriaCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Asignar));
    }

    /// <summary>AgregarCriterioCommand. Rol: PO.</summary>
    [HttpPost("{id:guid}/criterios")]
    public Task<IActionResult> AgregarCriterio(Guid id, [FromBody] AgregarCriterioCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(AgregarCriterio));
    }
}
