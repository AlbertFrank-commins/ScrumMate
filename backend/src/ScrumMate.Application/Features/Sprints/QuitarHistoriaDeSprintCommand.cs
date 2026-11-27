using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Sprints;

/// <summary>Devuelve una historia al backlog. Rol: Scrum Master.</summary>
public sealed record QuitarHistoriaDeSprintCommand(Guid SprintId, Guid HistoriaId) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class QuitarHistoriaDeSprintValidator : AbstractValidator<QuitarHistoriaDeSprintCommand>
{
    public QuitarHistoriaDeSprintValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class QuitarHistoriaDeSprintHandler : IRequestHandler<QuitarHistoriaDeSprintCommand>
{
    private readonly ISprintRepository _sprints;
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public QuitarHistoriaDeSprintHandler(ISprintRepository sprints, IHistoriaRepository historias, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _sprints = sprints;
        _historias = historias;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(QuitarHistoriaDeSprintCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Sprint.QuitarHistoria.
        throw new NotImplementedException("QuitarHistoriaDeSprintCommand");
    }
}
