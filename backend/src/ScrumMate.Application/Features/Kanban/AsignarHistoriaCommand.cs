using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Application.Features.Backlog;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Kanban;

/// <summary>Asigna o desasigna un responsable. Rol: miembro.</summary>
public sealed record AsignarHistoriaCommand(Guid HistoriaId, Guid? UsuarioId) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class AsignarHistoriaValidator : AbstractValidator<AsignarHistoriaCommand>
{
    public AsignarHistoriaValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class AsignarHistoriaHandler : IRequestHandler<AsignarHistoriaCommand>
{
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public AsignarHistoriaHandler(IHistoriaRepository historias, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _historias = historias;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(AsignarHistoriaCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Validar que el usuario sea miembro y Historia.AsignarA.
        throw new NotImplementedException("AsignarHistoriaCommand");
    }
}
