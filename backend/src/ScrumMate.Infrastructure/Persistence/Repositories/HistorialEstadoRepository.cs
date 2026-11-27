using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence.Repositories;

public sealed class HistorialEstadoRepository : IHistorialEstadoRepository
{
    private readonly AppDbContext _db;

    public HistorialEstadoRepository(AppDbContext db)
    {
        _db = db;
    }

    public Task<IReadOnlyList<HistorialEstado>> ListarPorSprintAsync(Guid sprintId, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ListarPorSprintAsync));
    }
}
