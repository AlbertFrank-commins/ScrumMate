using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Auth;

public sealed record UsuarioDto(Guid Id, string Nombre, string Email);

public sealed record SesionDto(string Token, UsuarioDto Usuario);
