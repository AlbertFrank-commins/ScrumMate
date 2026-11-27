using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Auth;

/// <summary>Inicia sesión y devuelve el JWT. Público.</summary>
public sealed record IniciarSesionCommand(string Email, string Password) : IRequest<SesionDto>;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class IniciarSesionValidator : AbstractValidator<IniciarSesionCommand>
{
    public IniciarSesionValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class IniciarSesionHandler : IRequestHandler<IniciarSesionCommand, SesionDto>
{
    private readonly IUsuarioRepository _usuarios;
    private readonly IPasswordHasher _hasher;
    private readonly IJwtService _jwt;

    public IniciarSesionHandler(IUsuarioRepository usuarios, IPasswordHasher hasher, IJwtService jwt)
    {
        _usuarios = usuarios;
        _hasher = hasher;
        _jwt = jwt;
    }

    public Task<SesionDto> Handle(IniciarSesionCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Buscar por email, verificar hash, generar token con IJwtService. Credenciales inválidas → ProhibidoException.
        throw new NotImplementedException("IniciarSesionCommand");
    }
}
