// Llamadas HTTP de sprints. Usar `cliente` de ./cliente.
import type { CrearSprintDto, Sprint, Tablero } from './tipos'

/** GET /proyectos/{id}/sprints */
export async function listar(proyectoId: string): Promise<Sprint[]> {
  throw new Error('TODO (Eliana): GET /proyectos/{id}/sprints')
}

/** GET /sprints/{id} */
export async function obtener(sprintId: string): Promise<Sprint> {
  throw new Error('TODO (Eliana): GET /sprints/{id}')
}

/** POST /proyectos/{id}/sprints */
export async function crear(proyectoId: string, dto: CrearSprintDto): Promise<string> {
  throw new Error('TODO (Eliana): POST /proyectos/{id}/sprints')
}

/** POST /sprints/{id}/iniciar */
export async function iniciar(sprintId: string): Promise<void> {
  throw new Error('TODO (Eliana): POST /sprints/{id}/iniciar')
}

/** POST /sprints/{id}/cerrar */
export async function cerrar(sprintId: string): Promise<void> {
  throw new Error('TODO (Eliana): POST /sprints/{id}/cerrar')
}

/** POST /sprints/{id}/historias/{historiaId} */
export async function agregarHistoria(sprintId: string, historiaId: string): Promise<void> {
  throw new Error('TODO (Eliana): POST /sprints/{id}/historias/{historiaId}')
}

/** DELETE /sprints/{id}/historias/{historiaId} */
export async function quitarHistoria(sprintId: string, historiaId: string): Promise<void> {
  throw new Error('TODO (Eliana): DELETE /sprints/{id}/historias/{historiaId}')
}

/** GET /sprints/{id}/tablero */
export async function obtenerTablero(sprintId: string): Promise<Tablero> {
  throw new Error('TODO (Eliana): GET /sprints/{id}/tablero')
}
