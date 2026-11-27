using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Proyectos;

/// <summary>Cambia el rol de un miembro. Rol: Product Owner. RN-09.</summary>
public sealed record CambiarRolMiembroCommand(Guid ProyectoId, Guid UsuarioId, RolProyecto Rol) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class CambiarRolMiembroValidator : AbstractValidator<CambiarRolMiembroCommand>
{
    public CambiarRolMiembroValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class CambiarRolMiembroHandler : IRequestHandler<CambiarRolMiembroCommand>
{
    private readonly IProyectoRepository _proyectos;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public CambiarRolMiembroHandler(IProyectoRepository proyectos, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _proyectos = proyectos;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(CambiarRolMiembroCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Proyecto.CambiarRolMiembro.
        throw new NotImplementedException("CambiarRolMiembroCommand");
    }
}
