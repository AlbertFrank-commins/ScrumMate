using ScrumMate.Domain.Entities;

namespace ScrumMate.Application.Common.Interfaces;

/// <summary>Acceso a datos de Epica. Implementación en Infrastructure/Persistence/Repositories.</summary>
public interface IEpicaRepository
{
    Task<Epica?> ObtenerPorIdAsync(Guid id, CancellationToken ct = default);
    Task<IReadOnlyList<Epica>> ListarPorProyectoAsync(Guid proyectoId, CancellationToken ct = default);
    Task AgregarAsync(Epica epica, CancellationToken ct = default);
}
