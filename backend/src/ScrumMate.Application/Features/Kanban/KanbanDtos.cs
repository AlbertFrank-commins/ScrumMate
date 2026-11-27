using ScrumMate.Application.Features.Backlog;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Kanban;

public sealed record ColumnaDto(EstadoHistoria Estado, int Puntos, IReadOnlyList<HistoriaDto> Historias);

public sealed record TableroDto(Guid SprintId, IReadOnlyList<ColumnaDto> Columnas);
