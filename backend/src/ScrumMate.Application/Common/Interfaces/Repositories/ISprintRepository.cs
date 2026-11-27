using ScrumMate.Domain.Entities;

namespace ScrumMate.Application.Common.Interfaces;

/// <summary>Acceso a datos de Sprint. Implementación en Infrastructure/Persistence/Repositories.</summary>
public interface ISprintRepository
{
    Task<Sprint?> ObtenerPorIdAsync(Guid id, CancellationToken ct = default);
    Task<Sprint?> ObtenerConHistoriasAsync(Guid id, CancellationToken ct = default);
    Task<Sprint?> ObtenerActivoAsync(Guid proyectoId, CancellationToken ct = default);
    Task<IReadOnlyList<Sprint>> ListarPorProyectoAsync(Guid proyectoId, CancellationToken ct = default);
    Task AgregarAsync(Sprint sprint, CancellationToken ct = default);
}
