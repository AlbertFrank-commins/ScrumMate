using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Auth;

/// <summary>Devuelve el usuario autenticado.</summary>
public sealed record ObtenerUsuarioActualQuery() : IRequest<UsuarioDto>;

public sealed class ObtenerUsuarioActualHandler : IRequestHandler<ObtenerUsuarioActualQuery, UsuarioDto>
{
    private readonly IUsuarioActual _usuarioActual;
    private readonly IUsuarioRepository _usuarios;

    public ObtenerUsuarioActualHandler(IUsuarioActual usuarioActual, IUsuarioRepository usuarios)
    {
        _usuarioActual = usuarioActual;
        _usuarios = usuarios;
    }

    public Task<UsuarioDto> Handle(ObtenerUsuarioActualQuery request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Leer IUsuarioActual.Id y mapear a UsuarioDto.
        throw new NotImplementedException("ObtenerUsuarioActualQuery");
    }
}
