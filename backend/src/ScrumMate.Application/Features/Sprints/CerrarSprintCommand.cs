using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Sprints;

/// <summary>Cierra el sprint. Rol: Scrum Master (RN-03). RN-06.</summary>
public sealed record CerrarSprintCommand(Guid SprintId) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class CerrarSprintValidator : AbstractValidator<CerrarSprintCommand>
{
    public CerrarSprintValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class CerrarSprintHandler : IRequestHandler<CerrarSprintCommand>
{
    private readonly ISprintRepository _sprints;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public CerrarSprintHandler(ISprintRepository sprints, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _sprints = sprints;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(CerrarSprintCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): ObtenerConHistoriasAsync y Sprint.Cerrar.
        throw new NotImplementedException("CerrarSprintCommand");
    }
}
