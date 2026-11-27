import Pendiente from '../../components/ui/Pendiente'

interface BadgeProps {
  texto: string
  color?: 'gris' | 'primario' | 'exito' | 'advertencia' | 'peligro' | 'ia'
}

/**
 * Etiqueta redondeada para prioridad, puntos, épica o rol.
 * Responsable: Eliana (Módulo B).
 */
export default function Badge(_props: BadgeProps) {
  // TODO (Eliana): implementar según la guía UI/UX.
  return <Pendiente titulo="Badge" descripcion="Etiqueta redondeada para prioridad, puntos, épica o rol." />
}
