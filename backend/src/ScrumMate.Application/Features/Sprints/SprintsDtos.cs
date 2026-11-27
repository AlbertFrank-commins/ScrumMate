using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Sprints;

public sealed record SprintDto(
    Guid Id,
    string Nombre,
    string? Meta,
    DateOnly FechaInicio,
    DateOnly FechaFin,
    EstadoSprint Estado,
    int PuntosComprometidos,
    int PuntosCompletados);
