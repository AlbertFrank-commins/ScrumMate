using Microsoft.EntityFrameworkCore;
using ScrumMate.Domain.Common;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Proyecto> Proyectos => Set<Proyecto>();
    public DbSet<MiembroProyecto> MiembrosProyecto => Set<MiembroProyecto>();
    public DbSet<Epica> Epicas => Set<Epica>();
    public DbSet<Historia> Historias => Set<Historia>();
    public DbSet<CriterioAceptacion> CriteriosAceptacion => Set<CriterioAceptacion>();
    public DbSet<Sprint> Sprints => Set<Sprint>();
    public DbSet<HistorialEstado> HistorialEstados => Set<HistorialEstado>();
    public DbSet<SugerenciaIa> SugerenciasIa => Set<SugerenciaIa>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<EntidadBase>())
        {
            if (entry.State == EntityState.Modified)
            {
                entry.Entity.MarcarActualizado();
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}
