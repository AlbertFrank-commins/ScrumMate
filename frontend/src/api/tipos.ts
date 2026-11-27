// Tipos del contrato de la API (Módulo A).
// Cuando la API publique Swagger, reemplazar por los generados con `npm run api:tipos` (src/api/esquema.d.ts).

export type RolProyecto = 'ProductOwner' | 'ScrumMaster' | 'Desarrollador'
export type EstadoHistoria = 'PorHacer' | 'EnProgreso' | 'EnRevision' | 'Hecho'
export type EstadoSprint = 'Planificado' | 'Activo' | 'Cerrado'
export type Prioridad = 'Baja' | 'Media' | 'Alta' | 'Critica'

export interface Usuario {
  id: string
  nombre: string
  email: string
}

export interface Sesion {
  token: string
  usuario: Usuario
}

export interface ProyectoResumen {
  id: string
  nombre: string
  descripcion?: string
  miRol: RolProyecto
  cantidadMiembros: number
}

export interface Miembro {
  usuarioId: string
  nombre: string
  email: string
  rol: RolProyecto
}

export interface ProyectoDetalle {
  id: string
  nombre: string
  descripcion?: string
  miembros: Miembro[]
}

export interface Epica {
  id: string
  titulo: string
  descripcion?: string
  color: string
}

export interface Historia {
  id: string
  titulo: string
  descripcion?: string
  prioridad: Prioridad
  puntos?: number
  estado: EstadoHistoria
  ordenBacklog: number
  epicaId?: string
  sprintId?: string
  asignadoAId?: string
}

export interface Criterio {
  id: string
  dado: string
  cuando: string
  entonces: string
  cumplido: boolean
}

export interface HistoriaDetalle {
  historia: Historia
  criterios: Criterio[]
}

export interface Sprint {
  id: string
  nombre: string
  meta?: string
  fechaInicio: string
  fechaFin: string
  estado: EstadoSprint
  puntosComprometidos: number
  puntosCompletados: number
}

export interface Columna {
  estado: EstadoHistoria
  puntos: number
  historias: Historia[]
}

export interface Tablero {
  sprintId: string
  columnas: Columna[]
}

export interface PuntoBurndown {
  fecha: string
  puntosRestantes?: number
  puntosIdeales: number
}

export interface Burndown {
  sprintId: string
  puntos: PuntoBurndown[]
}

export interface Velocidad {
  sprintId: string
  sprint: string
  comprometidos: number
  completados: number
}

// ----- IA -----
export interface HistoriaSugerida {
  titulo: string
  comoUn: string
  quiero: string
  para: string
  prioridad: Prioridad
}

export interface CriterioSugerido {
  dado: string
  cuando: string
  entonces: string
}

export interface SugerenciaHistorias {
  sugerenciaId: string
  historias: HistoriaSugerida[]
}

export interface SugerenciaCriterios {
  sugerenciaId: string
  criterios: CriterioSugerido[]
}

export interface EstimacionSugerida {
  sugerenciaId: string
  puntos: number
  justificacion: string
}

export interface ResumenSprint {
  sugerenciaId: string
  avance: string
  bloqueos: string[]
  riesgos: string[]
  recomendacion: string
}

// ----- Entradas -----
export interface CrearHistoriaDto {
  titulo: string
  descripcion?: string
  prioridad: Prioridad
  epicaId?: string
}

export interface CrearSprintDto {
  nombre: string
  meta?: string
  fechaInicio: string
  fechaFin: string
}
