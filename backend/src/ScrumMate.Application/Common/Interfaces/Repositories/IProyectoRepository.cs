using ScrumMate.Domain.Entities;

namespace ScrumMate.Application.Common.Interfaces;

/// <summary>Acceso a datos de Proyecto. Implementación en Infrastructure/Persistence/Repositories.</summary>
public interface IProyectoRepository
{
    Task<Proyecto?> ObtenerPorIdAsync(Guid id, CancellationToken ct = default);
    Task<Proyecto?> ObtenerConMiembrosAsync(Guid id, CancellationToken ct = default);
    Task<IReadOnlyList<Proyecto>> ListarPorUsuarioAsync(Guid usuarioId, CancellationToken ct = default);
    Task AgregarAsync(Proyecto proyecto, CancellationToken ct = default);
    void Eliminar(Proyecto proyecto);
}
