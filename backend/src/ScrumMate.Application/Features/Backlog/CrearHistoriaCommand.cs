using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Backlog;

/// <summary>Crea una historia al final del backlog. Rol: Product Owner (RN-02).</summary>
public sealed record CrearHistoriaCommand(Guid ProyectoId, string Titulo, string? Descripcion, Prioridad Prioridad, Guid? EpicaId) : IRequest<Guid>;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class CrearHistoriaValidator : AbstractValidator<CrearHistoriaCommand>
{
    public CrearHistoriaValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class CrearHistoriaHandler : IRequestHandler<CrearHistoriaCommand, Guid>
{
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public CrearHistoriaHandler(IHistoriaRepository historias, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _historias = historias;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task<Guid> Handle(CrearHistoriaCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): SiguienteOrdenAsync + Historia.Crear + AgregarAsync.
        throw new NotImplementedException("CrearHistoriaCommand");
    }
}
