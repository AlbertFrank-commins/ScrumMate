using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.IA.Modelos;

// ----- Formato que devuelve el LLM (ver /prompts) -----

public sealed record HistoriaSugeridaDto(string Titulo, string ComoUn, string Quiero, string Para, Prioridad Prioridad);

public sealed record CriterioSugeridoDto(string Dado, string Cuando, string Entonces);

public sealed record RespuestaHistorias(IReadOnlyList<HistoriaSugeridaDto> Historias);

public sealed record RespuestaCriterios(IReadOnlyList<CriterioSugeridoDto> Criterios);

public sealed record RespuestaEstimacion(int Puntos, string Justificacion);

public sealed record RespuestaResumen(string Avance, IReadOnlyList<string> Bloqueos, IReadOnlyList<string> Riesgos, string Recomendacion);

// ----- Lo que devuelve la API al frontend -----

public sealed record SugerenciaHistoriasDto(Guid SugerenciaId, IReadOnlyList<HistoriaSugeridaDto> Historias);

public sealed record SugerenciaCriteriosDto(Guid SugerenciaId, IReadOnlyList<CriterioSugeridoDto> Criterios);

public sealed record EstimacionSugeridaDto(Guid SugerenciaId, int Puntos, string Justificacion);

public sealed record ResumenSprintDto(Guid SugerenciaId, string Avance, IReadOnlyList<string> Bloqueos, IReadOnlyList<string> Riesgos, string Recomendacion);
