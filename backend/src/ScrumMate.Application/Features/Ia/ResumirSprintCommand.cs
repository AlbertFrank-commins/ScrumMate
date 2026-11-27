using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Application.IA;
using ScrumMate.Application.IA.Modelos;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Ia;

/// <summary>Resume avance, bloqueos y riesgos del sprint. Rol: miembro.</summary>
public sealed record ResumirSprintCommand(Guid SprintId) : IRequest<ResumenSprintDto>;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class ResumirSprintValidator : AbstractValidator<ResumirSprintCommand>
{
    public ResumirSprintValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class ResumirSprintHandler : IRequestHandler<ResumirSprintCommand, ResumenSprintDto>
{
    private readonly IAsistenteIaService _asistente;
    private readonly IAutorizacionProyecto _autorizacion;

    public ResumirSprintHandler(IAsistenteIaService asistente, IAutorizacionProyecto autorizacion)
    {
        _asistente = asistente;
        _autorizacion = autorizacion;
    }

    public Task<ResumenSprintDto> Handle(ResumirSprintCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): IAsistenteIaService.ResumirSprintAsync.
        throw new NotImplementedException("ResumirSprintCommand");
    }
}
