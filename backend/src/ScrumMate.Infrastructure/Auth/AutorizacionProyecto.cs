using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;
using ScrumMate.Infrastructure.Persistence;

namespace ScrumMate.Infrastructure.Auth;

public sealed class AutorizacionProyecto : IAutorizacionProyecto
{
    private readonly AppDbContext _db;
    private readonly IUsuarioActual _usuarioActual;

    public AutorizacionProyecto(AppDbContext db, IUsuarioActual usuarioActual)
    {
        _db = db;
        _usuarioActual = usuarioActual;
    }

    public Task<RolProyecto?> ObtenerRolAsync(Guid proyectoId, CancellationToken ct = default)
    {
        // TODO (Albert): consultar miembros_proyecto con _usuarioActual.Id.
        throw new NotImplementedException(nameof(ObtenerRolAsync));
    }

    public Task ExigirMiembroAsync(Guid proyectoId, CancellationToken ct = default)
    {
        // TODO (Albert): lanzar ProhibidoException si no es miembro.
        throw new NotImplementedException(nameof(ExigirMiembroAsync));
    }

    public Task ExigirRolAsync(Guid proyectoId, IReadOnlyCollection<RolProyecto> roles, CancellationToken ct = default)
    {
        // TODO (Albert): lanzar ProhibidoException si el rol no está en la lista.
        throw new NotImplementedException(nameof(ExigirRolAsync));
    }
}
