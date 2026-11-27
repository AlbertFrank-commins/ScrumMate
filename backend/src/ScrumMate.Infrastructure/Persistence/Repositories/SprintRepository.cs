using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence.Repositories;

public sealed class SprintRepository : ISprintRepository
{
    private readonly AppDbContext _db;

    public SprintRepository(AppDbContext db)
    {
        _db = db;
    }

    public Task<Sprint?> ObtenerPorIdAsync(Guid id, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ObtenerPorIdAsync));
    }

    public Task<Sprint?> ObtenerConHistoriasAsync(Guid id, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ObtenerConHistoriasAsync));
    }

    public Task<Sprint?> ObtenerActivoAsync(Guid proyectoId, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ObtenerActivoAsync));
    }

    public Task<IReadOnlyList<Sprint>> ListarPorProyectoAsync(Guid proyectoId, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ListarPorProyectoAsync));
    }

    public Task AgregarAsync(Sprint sprint, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(AgregarAsync));
    }
}
