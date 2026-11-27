using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence.Repositories;

public sealed class SugerenciaIaRepository : ISugerenciaIaRepository
{
    private readonly AppDbContext _db;

    public SugerenciaIaRepository(AppDbContext db)
    {
        _db = db;
    }

    public Task<SugerenciaIa?> ObtenerPorIdAsync(Guid id, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(ObtenerPorIdAsync));
    }

    public Task AgregarAsync(SugerenciaIa sugerencia, CancellationToken ct = default)
    {
        // TODO (Albert)
        throw new NotImplementedException(nameof(AgregarAsync));
    }
}
