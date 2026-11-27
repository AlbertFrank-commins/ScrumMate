using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Proyectos;

/// <summary>Actualiza nombre y descripción. Rol: Product Owner.</summary>
public sealed record ActualizarProyectoCommand(Guid ProyectoId, string Nombre, string? Descripcion) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class ActualizarProyectoValidator : AbstractValidator<ActualizarProyectoCommand>
{
    public ActualizarProyectoValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class ActualizarProyectoHandler : IRequestHandler<ActualizarProyectoCommand>
{
    private readonly IProyectoRepository _proyectos;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public ActualizarProyectoHandler(IProyectoRepository proyectos, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _proyectos = proyectos;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(ActualizarProyectoCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): ExigirRolAsync(ProductOwner) y Proyecto.Actualizar.
        throw new NotImplementedException("ActualizarProyectoCommand");
    }
}
