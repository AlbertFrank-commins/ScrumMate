using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Sprints;

/// <summary>Inicia el sprint. Rol: Scrum Master (RN-03). RN-01.</summary>
public sealed record IniciarSprintCommand(Guid SprintId) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class IniciarSprintValidator : AbstractValidator<IniciarSprintCommand>
{
    public IniciarSprintValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class IniciarSprintHandler : IRequestHandler<IniciarSprintCommand>
{
    private readonly ISprintRepository _sprints;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public IniciarSprintHandler(ISprintRepository sprints, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _sprints = sprints;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(IniciarSprintCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): ObtenerActivoAsync para saber si hay otro activo y Sprint.Iniciar.
        throw new NotImplementedException("IniciarSprintCommand");
    }
}
