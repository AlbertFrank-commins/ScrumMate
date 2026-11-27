using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence.Configurations;

public sealed class HistorialEstadoConfiguration : IEntityTypeConfiguration<HistorialEstado>
{
    public void Configure(EntityTypeBuilder<HistorialEstado> builder)
    {
        builder.ToTable("historial_estados");
        builder.HasKey(x => x.Id);

        // TODO (Albert): columnas en snake_case, longitudes, índices y relaciones.
        // FK historia_id; índice (historia_id, fecha).
    }
}
