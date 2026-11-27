import Pendiente from '../../components/ui/Pendiente'

interface ResumenSprintIaProps {
  sprintId: string
}

/**
 * Tarjeta con avance, bloqueos, riesgos y recomendación del sprint.
 * Responsable: Eliana (Módulo B).
 */
export default function ResumenSprintIa(_props: ResumenSprintIaProps) {
  // TODO (Eliana): botón Regenerar.
  return <Pendiente titulo="ResumenSprintIa" descripcion="Tarjeta con avance, bloqueos, riesgos y recomendación del sprint." />
}
