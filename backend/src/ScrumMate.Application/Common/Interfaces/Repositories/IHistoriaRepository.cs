using ScrumMate.Domain.Entities;

namespace ScrumMate.Application.Common.Interfaces;

/// <summary>Acceso a datos de Historia. Implementación en Infrastructure/Persistence/Repositories.</summary>
public interface IHistoriaRepository
{
    Task<Historia?> ObtenerPorIdAsync(Guid id, CancellationToken ct = default);
    Task<Historia?> ObtenerConCriteriosAsync(Guid id, CancellationToken ct = default);
    Task<CriterioAceptacion?> ObtenerCriterioPorIdAsync(Guid criterioId, CancellationToken ct = default);
    Task<IReadOnlyList<Historia>> ListarBacklogAsync(Guid proyectoId, CancellationToken ct = default);
    Task<IReadOnlyList<Historia>> ListarPorSprintAsync(Guid sprintId, CancellationToken ct = default);
    Task<int> SiguienteOrdenAsync(Guid proyectoId, CancellationToken ct = default);
    Task AgregarAsync(Historia historia, CancellationToken ct = default);
    void Eliminar(Historia historia);
}
