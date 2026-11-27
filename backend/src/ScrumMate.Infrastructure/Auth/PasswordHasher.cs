using ScrumMate.Application.Common.Interfaces;

namespace ScrumMate.Infrastructure.Auth;

public sealed class PasswordHasher : IPasswordHasher
{
    public string Hash(string password)
    {
        // TODO (Albert): BCrypt.Net.BCrypt.HashPassword(password, workFactor: 11)
        throw new NotImplementedException(nameof(Hash));
    }

    public bool Verificar(string password, string hash)
    {
        // TODO (Albert): BCrypt.Net.BCrypt.Verify(password, hash)
        throw new NotImplementedException(nameof(Verificar));
    }
}
