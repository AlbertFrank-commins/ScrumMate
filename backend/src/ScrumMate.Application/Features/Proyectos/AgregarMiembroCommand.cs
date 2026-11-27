using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Proyectos;

/// <summary>Agrega un miembro por correo. Rol: Product Owner.</summary>
public sealed record AgregarMiembroCommand(Guid ProyectoId, string Email, RolProyecto Rol) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class AgregarMiembroValidator : AbstractValidator<AgregarMiembroCommand>
{
    public AgregarMiembroValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class AgregarMiembroHandler : IRequestHandler<AgregarMiembroCommand>
{
    private readonly IProyectoRepository _proyectos;
    private readonly IUsuarioRepository _usuarios;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public AgregarMiembroHandler(IProyectoRepository proyectos, IUsuarioRepository usuarios, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _proyectos = proyectos;
        _usuarios = usuarios;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(AgregarMiembroCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Buscar usuario por email (404 si no existe) y Proyecto.AgregarMiembro.
        throw new NotImplementedException("AgregarMiembroCommand");
    }
}
