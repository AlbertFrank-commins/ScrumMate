// Llamadas HTTP de reportes. Usar `cliente` de ./cliente.
import type { Burndown, Velocidad } from './tipos'

/** GET /sprints/{id}/burndown */
export async function burndown(sprintId: string): Promise<Burndown> {
  throw new Error('TODO (Eliana): GET /sprints/{id}/burndown')
}

/** GET /proyectos/{id}/velocidad */
export async function velocidad(proyectoId: string): Promise<Velocidad[]> {
  throw new Error('TODO (Eliana): GET /proyectos/{id}/velocidad')
}
