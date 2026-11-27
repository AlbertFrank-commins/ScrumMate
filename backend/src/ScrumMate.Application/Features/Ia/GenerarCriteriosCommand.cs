using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Application.IA;
using ScrumMate.Application.IA.Modelos;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Ia;

/// <summary>Propone criterios Dado / Cuando / Entonces. Rol: Product Owner.</summary>
public sealed record GenerarCriteriosCommand(Guid HistoriaId) : IRequest<SugerenciaCriteriosDto>;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class GenerarCriteriosValidator : AbstractValidator<GenerarCriteriosCommand>
{
    public GenerarCriteriosValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class GenerarCriteriosHandler : IRequestHandler<GenerarCriteriosCommand, SugerenciaCriteriosDto>
{
    private readonly IAsistenteIaService _asistente;
    private readonly IAutorizacionProyecto _autorizacion;

    public GenerarCriteriosHandler(IAsistenteIaService asistente, IAutorizacionProyecto autorizacion)
    {
        _asistente = asistente;
        _autorizacion = autorizacion;
    }

    public Task<SugerenciaCriteriosDto> Handle(GenerarCriteriosCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): IAsistenteIaService.GenerarCriteriosAsync.
        throw new NotImplementedException("GenerarCriteriosCommand");
    }
}
