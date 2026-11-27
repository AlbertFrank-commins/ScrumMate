// Llamadas HTTP de historias. Usar `cliente` de ./cliente.
import type { CrearHistoriaDto, Epica, EstadoHistoria, Historia, HistoriaDetalle } from './tipos'

/** GET /proyectos/{id}/epicas */
export async function listarEpicas(proyectoId: string): Promise<Epica[]> {
  throw new Error('TODO (Eliana): GET /proyectos/{id}/epicas')
}

/** POST /proyectos/{id}/epicas */
export async function crearEpica(proyectoId: string, titulo: string, color: string): Promise<string> {
  throw new Error('TODO (Eliana): POST /proyectos/{id}/epicas')
}

/** GET /proyectos/{id}/historias */
export async function listarBacklog(proyectoId: string): Promise<Historia[]> {
  throw new Error('TODO (Eliana): GET /proyectos/{id}/historias')
}

/** GET /historias/{id} */
export async function obtener(historiaId: string): Promise<HistoriaDetalle> {
  throw new Error('TODO (Eliana): GET /historias/{id}')
}

/** POST /proyectos/{id}/historias */
export async function crear(proyectoId: string, dto: CrearHistoriaDto): Promise<string> {
  throw new Error('TODO (Eliana): POST /proyectos/{id}/historias')
}

/** PUT /historias/{id} */
export async function actualizar(historiaId: string, dto: CrearHistoriaDto): Promise<void> {
  throw new Error('TODO (Eliana): PUT /historias/{id}')
}

/** DELETE /historias/{id} */
export async function eliminar(historiaId: string): Promise<void> {
  throw new Error('TODO (Eliana): DELETE /historias/{id}')
}

/** PATCH /historias/{id}/estimacion */
export async function estimar(historiaId: string, puntos: number): Promise<void> {
  throw new Error('TODO (Eliana): PATCH /historias/{id}/estimacion')
}

/** PATCH /historias/{id}/estado */
export async function cambiarEstado(historiaId: string, nuevoEstado: EstadoHistoria): Promise<void> {
  throw new Error('TODO (Eliana): PATCH /historias/{id}/estado')
}

/** PATCH /historias/{id}/asignacion */
export async function asignar(historiaId: string, usuarioId: string | null): Promise<void> {
  throw new Error('TODO (Eliana): PATCH /historias/{id}/asignacion')
}

/** POST /historias/{id}/criterios */
export async function agregarCriterio(historiaId: string, dado: string, cuando: string, entonces: string): Promise<string> {
  throw new Error('TODO (Eliana): POST /historias/{id}/criterios')
}

/** PATCH /criterios/{id} */
export async function marcarCriterio(criterioId: string, cumplido: boolean): Promise<void> {
  throw new Error('TODO (Eliana): PATCH /criterios/{id}')
}

/** PUT /proyectos/{id}/backlog/orden */
export async function reordenar(proyectoId: string, historiaIds: string[]): Promise<void> {
  throw new Error('TODO (Eliana): PUT /proyectos/{id}/backlog/orden')
}
