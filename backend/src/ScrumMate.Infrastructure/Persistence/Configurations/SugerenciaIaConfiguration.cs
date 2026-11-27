using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence.Configurations;

public sealed class SugerenciaIaConfiguration : IEntityTypeConfiguration<SugerenciaIa>
{
    public void Configure(EntityTypeBuilder<SugerenciaIa> builder)
    {
        builder.ToTable("sugerencias_ia");
        builder.HasKey(x => x.Id);

        // TODO (Albert): columnas en snake_case, longitudes, índices y relaciones.
        // salida_json jsonb; modelo varchar(50).
    }
}
