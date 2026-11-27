using ScrumMate.Domain.Entities;

namespace ScrumMate.Application.Common.Interfaces;

/// <summary>Acceso a datos de HistorialEstado. Implementación en Infrastructure/Persistence/Repositories.</summary>
public interface IHistorialEstadoRepository
{
    Task<IReadOnlyList<HistorialEstado>> ListarPorSprintAsync(Guid sprintId, CancellationToken ct = default);
}
