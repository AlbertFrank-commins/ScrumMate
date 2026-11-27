using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence.Repositories;

public sealed class ProyectoRepository : IProyectoRepository
{
    private readonly AppDbContext _db;

    public ProyectoRepository(AppDbContext db)
    {
        _db = db;
    }

    public Task<Proyecto?> ObtenerPorIdAsync(Guid id, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ObtenerPorIdAsync));
    }

    public Task<Proyecto?> ObtenerConMiembrosAsync(Guid id, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ObtenerConMiembrosAsync));
    }

    public Task<IReadOnlyList<Proyecto>> ListarPorUsuarioAsync(Guid usuarioId, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ListarPorUsuarioAsync));
    }

    public Task AgregarAsync(Proyecto proyecto, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(AgregarAsync));
    }

    public void Eliminar(Proyecto proyecto)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(Eliminar));
    }
}
