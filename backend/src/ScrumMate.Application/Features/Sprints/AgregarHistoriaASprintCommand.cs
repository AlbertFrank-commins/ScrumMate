using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Sprints;

/// <summary>Mueve una historia del backlog al sprint. Rol: Scrum Master. RN-05.</summary>
public sealed record AgregarHistoriaASprintCommand(Guid SprintId, Guid HistoriaId) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class AgregarHistoriaASprintValidator : AbstractValidator<AgregarHistoriaASprintCommand>
{
    public AgregarHistoriaASprintValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class AgregarHistoriaASprintHandler : IRequestHandler<AgregarHistoriaASprintCommand>
{
    private readonly ISprintRepository _sprints;
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public AgregarHistoriaASprintHandler(ISprintRepository sprints, IHistoriaRepository historias, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _sprints = sprints;
        _historias = historias;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(AgregarHistoriaASprintCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Sprint.AgregarHistoria.
        throw new NotImplementedException("AgregarHistoriaASprintCommand");
    }
}
