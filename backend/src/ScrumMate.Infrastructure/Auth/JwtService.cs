using Microsoft.Extensions.Options;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Auth;

public sealed class JwtService : IJwtService
{
    private readonly JwtOptions _options;

    public JwtService(IOptions<JwtOptions> options)
    {
        _options = options.Value;
    }

    public string GenerarToken(Usuario usuario)
    {
        // TODO (Albert): JwtSecurityTokenHandler con claims sub, email y name; firma HMAC SHA-256 con _options.Secret.
        throw new NotImplementedException(nameof(GenerarToken));
    }
}
