using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Reportes;

public sealed record PuntoBurndownDto(DateOnly Fecha, int? PuntosRestantes, decimal PuntosIdeales);

public sealed record BurndownDto(Guid SprintId, IReadOnlyList<PuntoBurndownDto> Puntos);

public sealed record VelocidadDto(Guid SprintId, string Sprint, int Comprometidos, int Completados);

public sealed record ResumenEstadosDto(int PorHacer, int EnProgreso, int EnRevision, int Hecho);
