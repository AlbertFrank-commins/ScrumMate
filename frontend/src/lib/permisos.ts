import type { RolProyecto } from '../api/tipos'

export type Accion =
  | 'crearHistoria'
  | 'priorizarBacklog'
  | 'gestionarSprint'
  | 'gestionarMiembros'
  | 'moverTarjeta'
  | 'generarHistoriasIa'

/**
 * Solo decide si se muestra un botón. La regla real la valida la API (RN-02, RN-03).
 */
export function puede(rol: RolProyecto | null, accion: Accion): boolean {
  // TODO (Eliana): PO → crearHistoria, priorizarBacklog, gestionarMiembros, generarHistoriasIa;
  // SM → gestionarSprint; todos → moverTarjeta.
  throw new Error('TODO (Eliana): puede()')
}
