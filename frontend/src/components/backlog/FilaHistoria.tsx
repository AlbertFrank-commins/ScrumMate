import type { Historia } from '../../api/tipos'
import Pendiente from '../../components/ui/Pendiente'

interface FilaHistoriaProps {
  historia: Historia
}

/**
 * Fila del backlog: código, título, épica, prioridad, puntos, responsable.
 * Responsable: Eliana (Módulo B).
 */
export default function FilaHistoria(_props: FilaHistoriaProps) {
  // TODO (Eliana): usar Badge y avatar con iniciales.
  return <Pendiente titulo="FilaHistoria" descripcion="Fila del backlog: código, título, épica, prioridad, puntos, responsable." />
}
