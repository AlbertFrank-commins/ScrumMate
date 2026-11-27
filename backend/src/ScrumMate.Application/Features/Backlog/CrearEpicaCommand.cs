using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Backlog;

/// <summary>Crea una épica. Rol: Product Owner (RN-02).</summary>
public sealed record CrearEpicaCommand(Guid ProyectoId, string Titulo, string? Descripcion, string Color) : IRequest<Guid>;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class CrearEpicaValidator : AbstractValidator<CrearEpicaCommand>
{
    public CrearEpicaValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class CrearEpicaHandler : IRequestHandler<CrearEpicaCommand, Guid>
{
    private readonly IEpicaRepository _epicas;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public CrearEpicaHandler(IEpicaRepository epicas, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _epicas = epicas;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task<Guid> Handle(CrearEpicaCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Epica.Crear + AgregarAsync.
        throw new NotImplementedException("CrearEpicaCommand");
    }
}
