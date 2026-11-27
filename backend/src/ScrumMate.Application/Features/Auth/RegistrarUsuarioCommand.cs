using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Auth;

/// <summary>Registra un usuario nuevo. Público.</summary>
public sealed record RegistrarUsuarioCommand(string Nombre, string Email, string Password) : IRequest<UsuarioDto>;

/// <summary>Validaciones de entrada (formato, longitudes, requeridos). Las reglas de negocio van en el dominio.</summary>
public sealed class RegistrarUsuarioValidator : AbstractValidator<RegistrarUsuarioCommand>
{
    public RegistrarUsuarioValidator()
    {
        // TODO (Albert): RuleFor(x => x....).NotEmpty().MaximumLength(...);
    }
}

public sealed class RegistrarUsuarioHandler : IRequestHandler<RegistrarUsuarioCommand, UsuarioDto>
{
    private readonly IUsuarioRepository _usuarios;
    private readonly IPasswordHasher _hasher;
    private readonly IUnitOfWork _unitOfWork;

    public RegistrarUsuarioHandler(IUsuarioRepository usuarios, IPasswordHasher hasher, IUnitOfWork unitOfWork)
    {
        _usuarios = usuarios;
        _hasher = hasher;
        _unitOfWork = unitOfWork;
    }

    public Task<UsuarioDto> Handle(RegistrarUsuarioCommand request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Validar email único (IUsuarioRepository.ExisteEmailAsync), hashear la contraseña, Usuario.Crear, guardar y devolver el DTO.
        throw new NotImplementedException("RegistrarUsuarioCommand");
    }
}
