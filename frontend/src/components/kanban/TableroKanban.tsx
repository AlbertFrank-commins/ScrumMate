import type { EstadoHistoria, Tablero } from '../../api/tipos'
import Pendiente from '../../components/ui/Pendiente'

interface TableroKanbanProps {
  tablero: Tablero
  onMover: (historiaId: string, estado: EstadoHistoria) => void
}

/**
 * Tablero con 4 columnas y arrastrar y soltar.
 * Responsable: Eliana (Módulo B).
 */
export default function TableroKanban(_props: TableroKanbanProps) {
  // TODO (Eliana): @dnd-kit/core; revertir el movimiento si la API responde 409.
  return <Pendiente titulo="TableroKanban" descripcion="Tablero con 4 columnas y arrastrar y soltar." />
}
