using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Backlog;

/// <summary>Guarda el nuevo orden del backlog. Rol: Product Owner (RN-02).</summary>
public sealed record ReordenarBacklogCommand(Guid ProyectoId, IReadOnlyList<Guid> HistoriaIds) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class ReordenarBacklogValidator : AbstractValidator<ReordenarBacklogCommand>
{
    public ReordenarBacklogValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class ReordenarBacklogHandler : IRequestHandler<ReordenarBacklogCommand>
{
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public ReordenarBacklogHandler(IHistoriaRepository historias, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _historias = historias;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(ReordenarBacklogCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Recorrer HistoriaIds y llamar CambiarOrden(i).
        throw new NotImplementedException("ReordenarBacklogCommand");
    }
}
