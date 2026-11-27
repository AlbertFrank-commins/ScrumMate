using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Proyectos;

public sealed record ProyectoResumenDto(Guid Id, string Nombre, string? Descripcion, RolProyecto MiRol, int CantidadMiembros);

public sealed record MiembroDto(Guid UsuarioId, string Nombre, string Email, RolProyecto Rol);

public sealed record ProyectoDetalleDto(Guid Id, string Nombre, string? Descripcion, IReadOnlyList<MiembroDto> Miembros);
