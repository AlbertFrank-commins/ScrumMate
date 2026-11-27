using ScrumMate.Application.Common.Interfaces;

namespace ScrumMate.Infrastructure.Persistence;

public sealed class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _db;

    public UnitOfWork(AppDbContext db)
    {
        _db = db;
    }

    public Task<int> GuardarCambiosAsync(CancellationToken ct = default) => _db.SaveChangesAsync(ct);
}
