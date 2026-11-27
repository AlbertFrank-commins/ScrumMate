using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence.Configurations;

public sealed class CriterioAceptacionConfiguration : IEntityTypeConfiguration<CriterioAceptacion>
{
    public void Configure(EntityTypeBuilder<CriterioAceptacion> builder)
    {
        builder.ToTable("criterios_aceptacion");
        builder.HasKey(x => x.Id);

        // TODO (Albert): columnas en snake_case, longitudes, índices y relaciones.
        // FK historia_id ON DELETE CASCADE.
    }
}
