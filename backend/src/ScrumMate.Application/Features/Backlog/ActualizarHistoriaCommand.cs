using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Backlog;

/// <summary>Edita una historia. Rol: Product Owner (RN-02).</summary>
public sealed record ActualizarHistoriaCommand(Guid HistoriaId, string Titulo, string? Descripcion, Prioridad Prioridad, Guid? EpicaId) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class ActualizarHistoriaValidator : AbstractValidator<ActualizarHistoriaCommand>
{
    public ActualizarHistoriaValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class ActualizarHistoriaHandler : IRequestHandler<ActualizarHistoriaCommand>
{
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public ActualizarHistoriaHandler(IHistoriaRepository historias, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _historias = historias;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(ActualizarHistoriaCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Historia.Actualizar.
        throw new NotImplementedException("ActualizarHistoriaCommand");
    }
}
