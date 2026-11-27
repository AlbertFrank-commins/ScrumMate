using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Sprints;

/// <summary>Crea un sprint planificado. Rol: Scrum Master (RN-03). RN-08.</summary>
public sealed record CrearSprintCommand(Guid ProyectoId, string Nombre, string? Meta, DateOnly FechaInicio, DateOnly FechaFin) : IRequest<Guid>;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class CrearSprintValidator : AbstractValidator<CrearSprintCommand>
{
    public CrearSprintValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class CrearSprintHandler : IRequestHandler<CrearSprintCommand, Guid>
{
    private readonly ISprintRepository _sprints;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public CrearSprintHandler(ISprintRepository sprints, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _sprints = sprints;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task<Guid> Handle(CrearSprintCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Sprint.Crear + AgregarAsync.
        throw new NotImplementedException("CrearSprintCommand");
    }
}
