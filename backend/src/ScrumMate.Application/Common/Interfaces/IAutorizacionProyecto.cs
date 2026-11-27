using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Common.Interfaces;

/// <summary>Comprueba el rol del usuario actual dentro de un proyecto (RN-02, RN-03).</summary>
public interface IAutorizacionProyecto
{
    Task<RolProyecto?> ObtenerRolAsync(Guid proyectoId, CancellationToken ct = default);

    /// <summary>Lanza ProhibidoException si el usuario no es miembro.</summary>
    Task ExigirMiembroAsync(Guid proyectoId, CancellationToken ct = default);

    /// <summary>Lanza ProhibidoException si el usuario no tiene alguno de los roles.</summary>
    Task ExigirRolAsync(Guid proyectoId, IReadOnlyCollection<RolProyecto> roles, CancellationToken ct = default);
}
