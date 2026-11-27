using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Application.IA;
using ScrumMate.Application.IA.Modelos;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Ia;

/// <summary>Sugiere puntos Fibonacci con justificación. Rol: miembro.</summary>
public sealed record SugerirEstimacionCommand(Guid HistoriaId) : IRequest<EstimacionSugeridaDto>;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class SugerirEstimacionValidator : AbstractValidator<SugerirEstimacionCommand>
{
    public SugerirEstimacionValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class SugerirEstimacionHandler : IRequestHandler<SugerirEstimacionCommand, EstimacionSugeridaDto>
{
    private readonly IAsistenteIaService _asistente;
    private readonly IAutorizacionProyecto _autorizacion;

    public SugerirEstimacionHandler(IAsistenteIaService asistente, IAutorizacionProyecto autorizacion)
    {
        _asistente = asistente;
        _autorizacion = autorizacion;
    }

    public Task<EstimacionSugeridaDto> Handle(SugerirEstimacionCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): IAsistenteIaService.SugerirEstimacionAsync.
        throw new NotImplementedException("SugerirEstimacionCommand");
    }
}
