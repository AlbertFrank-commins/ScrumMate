using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Backlog;

/// <summary>Asigna puntos Fibonacci. Rol: miembro. RN-04.</summary>
public sealed record EstimarHistoriaCommand(Guid HistoriaId, int Puntos) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class EstimarHistoriaValidator : AbstractValidator<EstimarHistoriaCommand>
{
    public EstimarHistoriaValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class EstimarHistoriaHandler : IRequestHandler<EstimarHistoriaCommand>
{
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public EstimarHistoriaHandler(IHistoriaRepository historias, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _historias = historias;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(EstimarHistoriaCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Historia.Estimar.
        throw new NotImplementedException("EstimarHistoriaCommand");
    }
}
