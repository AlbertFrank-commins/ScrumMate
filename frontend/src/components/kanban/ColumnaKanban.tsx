import type { Columna } from '../../api/tipos'
import Pendiente from '../../components/ui/Pendiente'

interface ColumnaKanbanProps {
  columna: Columna
}

/**
 * Columna con título, contador y suma de puntos.
 * Responsable: Eliana (Módulo B).
 */
export default function ColumnaKanban(_props: ColumnaKanbanProps) {
  // TODO (Eliana): usar COLUMNAS_KANBAN para el color.
  return <Pendiente titulo="ColumnaKanban" descripcion="Columna con título, contador y suma de puntos." />
}
