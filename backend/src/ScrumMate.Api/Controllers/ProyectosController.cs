using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ScrumMate.Application.Features.Proyectos;
using ScrumMate.Application.Features.Backlog;
using ScrumMate.Application.Features.Sprints;

namespace ScrumMate.Api.Controllers;

/// <summary>Los controllers no tienen lógica: solo envían el command o query a MediatR.</summary>
[ApiController]
[Authorize]
[Route("api/v1/proyectos")]
public sealed class ProyectosController : ControllerBase
{
    private readonly ISender _mediator;

    public ProyectosController(ISender mediator)
    {
        _mediator = mediator;
    }

    /// <summary>ListarMisProyectosQuery.</summary>
    [HttpGet]
    public Task<IActionResult> Listar(CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Listar));
    }

    /// <summary>CrearProyectoCommand → 201.</summary>
    [HttpPost]
    public Task<IActionResult> Crear([FromBody] CrearProyectoCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Crear));
    }

    /// <summary>ObtenerProyectoQuery. Rol: miembro.</summary>
    [HttpGet("{id:guid}")]
    public Task<IActionResult> Obtener(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Obtener));
    }

    /// <summary>ActualizarProyectoCommand (comando with { ProyectoId = id }). Rol: PO.</summary>
    [HttpPut("{id:guid}")]
    public Task<IActionResult> Actualizar(Guid id, [FromBody] ActualizarProyectoCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Actualizar));
    }

    /// <summary>EliminarProyectoCommand. Rol: PO.</summary>
    [HttpDelete("{id:guid}")]
    public Task<IActionResult> Eliminar(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Eliminar));
    }

    /// <summary>AgregarMiembroCommand. Rol: PO.</summary>
    [HttpPost("{id:guid}/miembros")]
    public Task<IActionResult> AgregarMiembro(Guid id, [FromBody] AgregarMiembroCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(AgregarMiembro));
    }

    /// <summary>CambiarRolMiembroCommand. Rol: PO.</summary>
    [HttpPut("{id:guid}/miembros/{usuarioId:guid}")]
    public Task<IActionResult> CambiarRolMiembro(Guid id, Guid usuarioId, [FromBody] CambiarRolMiembroCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(CambiarRolMiembro));
    }

    /// <summary>QuitarMiembroCommand. Rol: PO.</summary>
    [HttpDelete("{id:guid}/miembros/{usuarioId:guid}")]
    public Task<IActionResult> QuitarMiembro(Guid id, Guid usuarioId, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(QuitarMiembro));
    }

    /// <summary>ListarEpicasQuery. Rol: miembro.</summary>
    [HttpGet("{id:guid}/epicas")]
    public Task<IActionResult> ListarEpicas(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(ListarEpicas));
    }

    /// <summary>CrearEpicaCommand. Rol: PO.</summary>
    [HttpPost("{id:guid}/epicas")]
    public Task<IActionResult> CrearEpica(Guid id, [FromBody] CrearEpicaCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(CrearEpica));
    }

    /// <summary>ObtenerBacklogQuery. Rol: miembro.</summary>
    [HttpGet("{id:guid}/historias")]
    public Task<IActionResult> ObtenerBacklog(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(ObtenerBacklog));
    }

    /// <summary>CrearHistoriaCommand. Rol: PO (RN-02).</summary>
    [HttpPost("{id:guid}/historias")]
    public Task<IActionResult> CrearHistoria(Guid id, [FromBody] CrearHistoriaCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(CrearHistoria));
    }

    /// <summary>ReordenarBacklogCommand. Rol: PO (RN-02).</summary>
    [HttpPut("{id:guid}/backlog/orden")]
    public Task<IActionResult> ReordenarBacklog(Guid id, [FromBody] ReordenarBacklogCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(ReordenarBacklog));
    }

    /// <summary>ListarSprintsQuery. Rol: miembro.</summary>
    [HttpGet("{id:guid}/sprints")]
    public Task<IActionResult> ListarSprints(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(ListarSprints));
    }

    /// <summary>CrearSprintCommand. Rol: SM (RN-03).</summary>
    [HttpPost("{id:guid}/sprints")]
    public Task<IActionResult> CrearSprint(Guid id, [FromBody] CrearSprintCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(CrearSprint));
    }

    /// <summary>ObtenerVelocidadQuery. Rol: miembro.</summary>
    [HttpGet("{id:guid}/velocidad")]
    public Task<IActionResult> ObtenerVelocidad(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(ObtenerVelocidad));
    }

    /// <summary>ObtenerResumenEstadosQuery. Rol: miembro.</summary>
    [HttpGet("{id:guid}/resumen-estados")]
    public Task<IActionResult> ObtenerResumenEstados(Guid id, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(ObtenerResumenEstados));
    }
}
