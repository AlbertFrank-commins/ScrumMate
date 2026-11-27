import type { EstadoHistoria, Prioridad } from '../api/tipos'

/** RN-04 */
export const PUNTOS_FIBONACCI = [1, 2, 3, 5, 8, 13, 21] as const

export const COLUMNAS_KANBAN: { estado: EstadoHistoria; titulo: string; color: string }[] = [
  { estado: 'PorHacer', titulo: 'Por hacer', color: '#64748B' },
  { estado: 'EnProgreso', titulo: 'En progreso', color: '#0EA5E9' },
  { estado: 'EnRevision', titulo: 'En revisión', color: '#D97706' },
  { estado: 'Hecho', titulo: 'Hecho', color: '#16A34A' },
]

export const ETIQUETA_PRIORIDAD: Record<Prioridad, string> = {
  Baja: 'Baja',
  Media: 'Media',
  Alta: 'Alta',
  Critica: 'Crítica',
}
