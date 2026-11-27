using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Proyectos;

/// <summary>Elimina el proyecto. Rol: Product Owner.</summary>
public sealed record EliminarProyectoCommand(Guid ProyectoId) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class EliminarProyectoValidator : AbstractValidator<EliminarProyectoCommand>
{
    public EliminarProyectoValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class EliminarProyectoHandler : IRequestHandler<EliminarProyectoCommand>
{
    private readonly IProyectoRepository _proyectos;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public EliminarProyectoHandler(IProyectoRepository proyectos, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _proyectos = proyectos;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(EliminarProyectoCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): ExigirRolAsync(ProductOwner) y eliminar.
        throw new NotImplementedException("EliminarProyectoCommand");
    }
}
