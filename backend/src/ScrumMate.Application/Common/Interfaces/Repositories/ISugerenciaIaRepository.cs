using ScrumMate.Domain.Entities;

namespace ScrumMate.Application.Common.Interfaces;

/// <summary>Acceso a datos de SugerenciaIa. Implementación en Infrastructure/Persistence/Repositories.</summary>
public interface ISugerenciaIaRepository
{
    Task<SugerenciaIa?> ObtenerPorIdAsync(Guid id, CancellationToken ct = default);
    Task AgregarAsync(SugerenciaIa sugerencia, CancellationToken ct = default);
}
