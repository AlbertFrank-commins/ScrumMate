// Llamadas HTTP de ia. Usar `cliente` de ./cliente.
import type { EstimacionSugerida, ResumenSprint, SugerenciaCriterios, SugerenciaHistorias } from './tipos'

/** POST /proyectos/{id}/ia/historias */
export async function generarHistorias(proyectoId: string, idea: string): Promise<SugerenciaHistorias> {
  throw new Error('TODO (Eliana): POST /proyectos/{id}/ia/historias')
}

/** POST /historias/{id}/ia/criterios */
export async function generarCriterios(historiaId: string): Promise<SugerenciaCriterios> {
  throw new Error('TODO (Eliana): POST /historias/{id}/ia/criterios')
}

/** POST /historias/{id}/ia/estimacion */
export async function sugerirEstimacion(historiaId: string): Promise<EstimacionSugerida> {
  throw new Error('TODO (Eliana): POST /historias/{id}/ia/estimacion')
}

/** POST /sprints/{id}/ia/resumen */
export async function resumirSprint(sprintId: string): Promise<ResumenSprint> {
  throw new Error('TODO (Eliana): POST /sprints/{id}/ia/resumen')
}

/** POST /proyectos/{id}/ia/chat (SSE con fetch + ReadableStream) */
export async function chat(proyectoId: string, pregunta: string, onFragmento: (texto: string) => void): Promise<void> {
  throw new Error('TODO (Eliana): POST /proyectos/{id}/ia/chat (SSE con fetch + ReadableStream)')
}

/** POST /ia/sugerencias/{id}/aceptar */
export async function aceptarSugerencia(sugerenciaId: string, salidaEditadaJson?: string): Promise<void> {
  throw new Error('TODO (Eliana): POST /ia/sugerencias/{id}/aceptar')
}
