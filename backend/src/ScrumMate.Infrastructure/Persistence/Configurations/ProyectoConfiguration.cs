using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence.Configurations;

public sealed class ProyectoConfiguration : IEntityTypeConfiguration<Proyecto>
{
    public void Configure(EntityTypeBuilder<Proyecto> builder)
    {
        builder.ToTable("proyectos");
        builder.HasKey(x => x.Id);

        // TODO (Albert): columnas en snake_case, longitudes, índices y relaciones.
        // nombre varchar(120); FK propietario_id → usuarios; relaciones con Miembros, Epicas y Sprints usando los campos privados (_miembros...).
    }
}
