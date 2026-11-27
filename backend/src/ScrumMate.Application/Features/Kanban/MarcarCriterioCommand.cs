using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Application.Features.Backlog;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Kanban;

/// <summary>Marca un criterio como cumplido o no. Rol: miembro.</summary>
public sealed record MarcarCriterioCommand(Guid CriterioId, bool Cumplido) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class MarcarCriterioValidator : AbstractValidator<MarcarCriterioCommand>
{
    public MarcarCriterioValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class MarcarCriterioHandler : IRequestHandler<MarcarCriterioCommand>
{
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public MarcarCriterioHandler(IHistoriaRepository historias, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _historias = historias;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(MarcarCriterioCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): ObtenerCriterioPorIdAsync y MarcarCumplido.
        throw new NotImplementedException("MarcarCriterioCommand");
    }
}
