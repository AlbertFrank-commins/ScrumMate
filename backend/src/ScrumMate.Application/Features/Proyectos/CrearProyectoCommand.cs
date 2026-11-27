using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Proyectos;

/// <summary>Crea un proyecto; el creador queda como Product Owner.</summary>
public sealed record CrearProyectoCommand(string Nombre, string? Descripcion) : IRequest<Guid>;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class CrearProyectoValidator : AbstractValidator<CrearProyectoCommand>
{
    public CrearProyectoValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class CrearProyectoHandler : IRequestHandler<CrearProyectoCommand, Guid>
{
    private readonly IProyectoRepository _proyectos;
    private readonly IUsuarioActual _usuarioActual;
    private readonly IUnitOfWork _unitOfWork;

    public CrearProyectoHandler(IProyectoRepository proyectos, IUsuarioActual usuarioActual, IUnitOfWork unitOfWork)
    {
        _proyectos = proyectos;
        _usuarioActual = usuarioActual;
        _unitOfWork = unitOfWork;
    }

    public Task<Guid> Handle(CrearProyectoCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Proyecto.Crear + AgregarAsync + GuardarCambiosAsync.
        throw new NotImplementedException("CrearProyectoCommand");
    }
}
