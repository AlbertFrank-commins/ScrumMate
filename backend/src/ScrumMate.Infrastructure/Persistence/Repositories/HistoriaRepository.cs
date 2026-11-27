using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence.Repositories;

public sealed class HistoriaRepository : IHistoriaRepository
{
    private readonly AppDbContext _db;

    public HistoriaRepository(AppDbContext db)
    {
        _db = db;
    }

    public Task<Historia?> ObtenerPorIdAsync(Guid id, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ObtenerPorIdAsync));
    }

    public Task<Historia?> ObtenerConCriteriosAsync(Guid id, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ObtenerConCriteriosAsync));
    }

    public Task<CriterioAceptacion?> ObtenerCriterioPorIdAsync(Guid criterioId, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ObtenerCriterioPorIdAsync));
    }

    public Task<IReadOnlyList<Historia>> ListarBacklogAsync(Guid proyectoId, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ListarBacklogAsync));
    }

    public Task<IReadOnlyList<Historia>> ListarPorSprintAsync(Guid sprintId, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ListarPorSprintAsync));
    }

    public Task<int> SiguienteOrdenAsync(Guid proyectoId, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(SiguienteOrdenAsync));
    }

    public Task AgregarAsync(Historia historia, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(AgregarAsync));
    }

    public void Eliminar(Historia historia)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(Eliminar));
    }
}
