using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence.Repositories;

public sealed class UsuarioRepository : IUsuarioRepository
{
    private readonly AppDbContext _db;

    public UsuarioRepository(AppDbContext db)
    {
        _db = db;
    }

    public Task<Usuario?> ObtenerPorIdAsync(Guid id, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ObtenerPorIdAsync));
    }

    public Task<Usuario?> ObtenerPorEmailAsync(string email, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ObtenerPorEmailAsync));
    }

    public Task<bool> ExisteEmailAsync(string email, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ExisteEmailAsync));
    }

    public Task AgregarAsync(Usuario usuario, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(AgregarAsync));
    }
}
