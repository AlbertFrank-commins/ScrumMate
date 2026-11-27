using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Application.IA;
using ScrumMate.Application.IA.Modelos;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Ia;

/// <summary>Genera de 3 a 6 historias desde una idea. Rol: Product Owner.</summary>
public sealed record GenerarHistoriasCommand(Guid ProyectoId, string Idea) : IRequest<SugerenciaHistoriasDto>;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class GenerarHistoriasValidator : AbstractValidator<GenerarHistoriasCommand>
{
    public GenerarHistoriasValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class GenerarHistoriasHandler : IRequestHandler<GenerarHistoriasCommand, SugerenciaHistoriasDto>
{
    private readonly IAsistenteIaService _asistente;
    private readonly IAutorizacionProyecto _autorizacion;

    public GenerarHistoriasHandler(IAsistenteIaService asistente, IAutorizacionProyecto autorizacion)
    {
        _asistente = asistente;
        _autorizacion = autorizacion;
    }

    public Task<SugerenciaHistoriasDto> Handle(GenerarHistoriasCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): IAsistenteIaService.GenerarHistoriasAsync. No guarda historias (RN-10).
        throw new NotImplementedException("GenerarHistoriasCommand");
    }
}
