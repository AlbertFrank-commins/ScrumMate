namespace ScrumMate.Infrastructure.Persistence;

/// <summary>Datos de demostración: usuario demo, proyecto ScrumMate y backlog de ejemplo.</summary>
public sealed class DbSeeder
{
    private readonly AppDbContext _db;

    public DbSeeder(AppDbContext db)
    {
        _db = db;
    }

    public Task SembrarAsync(CancellationToken ct = default)
    {
        // TODO (Albert): solo si la base está vacía; usar IPasswordHasher para la contraseña demo.
        throw new NotImplementedException(nameof(SembrarAsync));
    }
}
