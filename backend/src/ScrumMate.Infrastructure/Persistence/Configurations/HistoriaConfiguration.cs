using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence.Configurations;

public sealed class HistoriaConfiguration : IEntityTypeConfiguration<Historia>
{
    public void Configure(EntityTypeBuilder<Historia> builder)
    {
        builder.ToTable("historias");
        builder.HasKey(x => x.Id);

        // TODO (Albert): columnas en snake_case, longitudes, índices y relaciones.
        // titulo varchar(200), prioridad/estado smallint; índice (proyecto_id, orden_backlog); CHECK puntos IN (1,2,3,5,8,13,21); FKs a epicas, sprints y usuarios.
    }
}
