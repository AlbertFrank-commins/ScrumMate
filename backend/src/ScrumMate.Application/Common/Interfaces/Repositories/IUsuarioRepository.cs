using ScrumMate.Domain.Entities;

namespace ScrumMate.Application.Common.Interfaces;

/// <summary>Acceso a datos de Usuario. Implementación en Infrastructure/Persistence/Repositories.</summary>
public interface IUsuarioRepository
{
    Task<Usuario?> ObtenerPorIdAsync(Guid id, CancellationToken ct = default);
    Task<Usuario?> ObtenerPorEmailAsync(string email, CancellationToken ct = default);
    Task<bool> ExisteEmailAsync(string email, CancellationToken ct = default);
    Task AgregarAsync(Usuario usuario, CancellationToken ct = default);
}
