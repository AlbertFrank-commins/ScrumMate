using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Proyectos;

/// <summary>Quita un miembro. Rol: Product Owner. RN-09.</summary>
public sealed record QuitarMiembroCommand(Guid ProyectoId, Guid UsuarioId) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class QuitarMiembroValidator : AbstractValidator<QuitarMiembroCommand>
{
    public QuitarMiembroValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class QuitarMiembroHandler : IRequestHandler<QuitarMiembroCommand>
{
    private readonly IProyectoRepository _proyectos;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public QuitarMiembroHandler(IProyectoRepository proyectos, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _proyectos = proyectos;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(QuitarMiembroCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Proyecto.QuitarMiembro.
        throw new NotImplementedException("QuitarMiembroCommand");
    }
}
