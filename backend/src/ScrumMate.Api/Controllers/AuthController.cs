using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ScrumMate.Application.Features.Auth;

namespace ScrumMate.Api.Controllers;

/// <summary>Los controllers no tienen lógica: solo envían el command o query a MediatR.</summary>
[ApiController]
[Authorize]
[Route("api/v1/auth")]
public sealed class AuthController : ControllerBase
{
    private readonly ISender _mediator;

    public AuthController(ISender mediator)
    {
        _mediator = mediator;
    }

    /// <summary>RegistrarUsuarioCommand → 201 con UsuarioDto. Público.</summary>
    [HttpPost("registro")]
    [AllowAnonymous]
    public Task<IActionResult> Registrar([FromBody] RegistrarUsuarioCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(Registrar));
    }

    /// <summary>IniciarSesionCommand → 200 con SesionDto (token). Público.</summary>
    [HttpPost("login")]
    [AllowAnonymous]
    public Task<IActionResult> IniciarSesion([FromBody] IniciarSesionCommand comando, CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(IniciarSesion));
    }

    /// <summary>ObtenerUsuarioActualQuery → 200 con UsuarioDto.</summary>
    [HttpGet("yo")]
    public Task<IActionResult> ObtenerYo(CancellationToken ct)
    {
        // TODO (Albert): return Ok(await _mediator.Send(..., ct));
        throw new NotImplementedException(nameof(ObtenerYo));
    }
}
