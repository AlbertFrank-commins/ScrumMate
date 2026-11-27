using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Backlog;

/// <summary>Agrega un criterio de aceptación. Rol: Product Owner.</summary>
public sealed record AgregarCriterioCommand(Guid HistoriaId, string Dado, string Cuando, string Entonces) : IRequest<Guid>;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class AgregarCriterioValidator : AbstractValidator<AgregarCriterioCommand>
{
    public AgregarCriterioValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class AgregarCriterioHandler : IRequestHandler<AgregarCriterioCommand, Guid>
{
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public AgregarCriterioHandler(IHistoriaRepository historias, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _historias = historias;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task<Guid> Handle(AgregarCriterioCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Historia.AgregarCriterio.
        throw new NotImplementedException("AgregarCriterioCommand");
    }
}
