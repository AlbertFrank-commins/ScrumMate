using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Backlog;

/// <summary>Elimina una historia del backlog. Rol: Product Owner.</summary>
public sealed record EliminarHistoriaCommand(Guid HistoriaId) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class EliminarHistoriaValidator : AbstractValidator<EliminarHistoriaCommand>
{
    public EliminarHistoriaValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class EliminarHistoriaHandler : IRequestHandler<EliminarHistoriaCommand>
{
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public EliminarHistoriaHandler(IHistoriaRepository historias, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _historias = historias;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(EliminarHistoriaCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): No permitir si está en un sprint activo.
        throw new NotImplementedException("EliminarHistoriaCommand");
    }
}
