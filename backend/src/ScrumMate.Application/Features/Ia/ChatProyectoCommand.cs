using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Application.IA;
using ScrumMate.Application.IA.Modelos;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Ia;

/// <summary>Chat del proyecto con respuesta en streaming (SSE). Rol: miembro.</summary>
public sealed record ChatProyectoCommand(Guid ProyectoId, string Pregunta) : IStreamRequest<string>;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class ChatProyectoValidator : AbstractValidator<ChatProyectoCommand>
{
    public ChatProyectoValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class ChatProyectoHandler : IStreamRequestHandler<ChatProyectoCommand, string>
{
    private readonly IAsistenteIaService _asistente;
    private readonly IAutorizacionProyecto _autorizacion;

    public ChatProyectoHandler(IAsistenteIaService asistente, IAutorizacionProyecto autorizacion)
    {
        _asistente = asistente;
        _autorizacion = autorizacion;
    }

    public IAsyncEnumerable<string> Handle(ChatProyectoCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): IAsistenteIaService.ChatAsync y emitir cada fragmento.
        throw new NotImplementedException("ChatProyectoCommand");
    }
}
