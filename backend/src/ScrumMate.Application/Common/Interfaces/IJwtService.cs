using ScrumMate.Domain.Entities;

namespace ScrumMate.Application.Common.Interfaces;

public interface IJwtService
{
    string GenerarToken(Usuario usuario);
}
