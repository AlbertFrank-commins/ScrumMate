using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence.Configurations;

public sealed class MiembroProyectoConfiguration : IEntityTypeConfiguration<MiembroProyecto>
{
    public void Configure(EntityTypeBuilder<MiembroProyecto> builder)
    {
        builder.ToTable("miembros_proyecto");
        builder.HasKey(x => new { x.ProyectoId, x.UsuarioId });

        // TODO (Albert): columnas en snake_case, longitudes, índices y relaciones.
        // rol smallint; FK a proyectos y usuarios.
    }
}
