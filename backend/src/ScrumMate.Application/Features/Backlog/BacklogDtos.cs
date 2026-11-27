using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Backlog;

public sealed record EpicaDto(Guid Id, string Titulo, string? Descripcion, string Color);

public sealed record HistoriaDto(
    Guid Id,
    string Titulo,
    string? Descripcion,
    Prioridad Prioridad,
    int? Puntos,
    EstadoHistoria Estado,
    int OrdenBacklog,
    Guid? EpicaId,
    Guid? SprintId,
    Guid? AsignadoAId);

public sealed record CriterioDto(Guid Id, string Dado, string Cuando, string Entonces, bool Cumplido);

public sealed record HistoriaDetalleDto(HistoriaDto Historia, IReadOnlyList<CriterioDto> Criterios);
