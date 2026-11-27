using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence.Repositories;

public sealed class EpicaRepository : IEpicaRepository
{
    private readonly AppDbContext _db;

    public EpicaRepository(AppDbContext db)
    {
        _db = db;
    }

    public Task<Epica?> ObtenerPorIdAsync(Guid id, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ObtenerPorIdAsync));
    }

    public Task<IReadOnlyList<Epica>> ListarPorProyectoAsync(Guid proyectoId, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ListarPorProyectoAsync));
    }

    public Task AgregarAsync(Epica epica, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(AgregarAsync));
    }
}
