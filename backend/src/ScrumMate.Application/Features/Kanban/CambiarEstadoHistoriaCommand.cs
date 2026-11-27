using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Application.Features.Backlog;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Kanban;

/// <summary>Mueve la historia de columna. Rol: miembro. RN-07.</summary>
public sealed record CambiarEstadoHistoriaCommand(Guid HistoriaId, EstadoHistoria NuevoEstado) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class CambiarEstadoHistoriaValidator : AbstractValidator<CambiarEstadoHistoriaCommand>
{
    public CambiarEstadoHistoriaValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class CambiarEstadoHistoriaHandler : IRequestHandler<CambiarEstadoHistoriaCommand>
{
    private readonly IHistoriaRepository _historias;
    private readonly IUsuarioActual _usuarioActual;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public CambiarEstadoHistoriaHandler(IHistoriaRepository historias, IUsuarioActual usuarioActual, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _historias = historias;
        _usuarioActual = usuarioActual;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(CambiarEstadoHistoriaCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Historia.CambiarEstado(nuevo, usuarioActual.Id).
        throw new NotImplementedException("CambiarEstadoHistoriaCommand");
    }
}
