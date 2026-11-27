// Llamadas HTTP de proyectos. Usar `cliente` de ./cliente.
import type { ProyectoDetalle, ProyectoResumen, RolProyecto } from './tipos'

/** GET /proyectos */
export async function listar(): Promise<ProyectoResumen[]> {
  throw new Error('TODO (Eliana): GET /proyectos')
}

/** GET /proyectos/{id} */
export async function obtener(id: string): Promise<ProyectoDetalle> {
  throw new Error('TODO (Eliana): GET /proyectos/{id}')
}

/** POST /proyectos */
export async function crear(nombre: string, descripcion?: string): Promise<string> {
  throw new Error('TODO (Eliana): POST /proyectos')
}

/** PUT /proyectos/{id} */
export async function actualizar(id: string, nombre: string, descripcion?: string): Promise<void> {
  throw new Error('TODO (Eliana): PUT /proyectos/{id}')
}

/** DELETE /proyectos/{id} */
export async function eliminar(id: string): Promise<void> {
  throw new Error('TODO (Eliana): DELETE /proyectos/{id}')
}

/** POST /proyectos/{id}/miembros */
export async function agregarMiembro(id: string, email: string, rol: RolProyecto): Promise<void> {
  throw new Error('TODO (Eliana): POST /proyectos/{id}/miembros')
}

/** PUT /proyectos/{id}/miembros/{usuarioId} */
export async function cambiarRolMiembro(id: string, usuarioId: string, rol: RolProyecto): Promise<void> {
  throw new Error('TODO (Eliana): PUT /proyectos/{id}/miembros/{usuarioId}')
}

/** DELETE /proyectos/{id}/miembros/{usuarioId} */
export async function quitarMiembro(id: string, usuarioId: string): Promise<void> {
  throw new Error('TODO (Eliana): DELETE /proyectos/{id}/miembros/{usuarioId}')
}
