using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Application.IA;
using ScrumMate.Application.IA.Modelos;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Ia;

/// <summary>Convierte una sugerencia en datos reales. RN-10.</summary>
public sealed record AceptarSugerenciaCommand(Guid SugerenciaId, string? SalidaEditadaJson) : IRequest;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class AceptarSugerenciaValidator : AbstractValidator<AceptarSugerenciaCommand>
{
    public AceptarSugerenciaValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class AceptarSugerenciaHandler : IRequestHandler<AceptarSugerenciaCommand>
{
    private readonly ISugerenciaIaRepository _sugerencias;
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;
    private readonly IUnitOfWork _unitOfWork;

    public AceptarSugerenciaHandler(ISugerenciaIaRepository sugerencias, IHistoriaRepository historias, IAutorizacionProyecto autorizacion, IUnitOfWork unitOfWork)
    {
        _sugerencias = sugerencias;
        _historias = historias;
        _autorizacion = autorizacion;
        _unitOfWork = unitOfWork;
    }

    public Task Handle(AceptarSugerenciaCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Según Tipo: crear historias, agregar criterios o estimar. Marcar SugerenciaIa.Aceptar.
        throw new NotImplementedException("AceptarSugerenciaCommand");
    }
}
