using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScrumMate.Domain.Entities;

namespace ScrumMate.Infrastructure.Persistence.Configurations;

public sealed class EpicaConfiguration : IEntityTypeConfiguration<Epica>
{
    public void Configure(EntityTypeBuilder<Epica> builder)
    {
        builder.ToTable("epicas");
        builder.HasKey(x => x.Id);

        // TODO (Albert): columnas en snake_case, longitudes, índices y relaciones.
        // titulo varchar(150), color varchar(7); FK proyecto_id.
    }
}
