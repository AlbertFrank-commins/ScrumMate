import type { Historia } from '../../api/tipos'
import Pendiente from '../../components/ui/Pendiente'

interface ListaBacklogProps {
  historias: Historia[]
  onReordenar: (ids: string[]) => void
}

/**
 * Lista ordenable de historias (solo el PO puede arrastrar).
 * Responsable: Eliana (Módulo B).
 */
export default function ListaBacklog(_props: ListaBacklogProps) {
  // TODO (Eliana): @dnd-kit/sortable; agrupar por sprint activo y backlog.
  return <Pendiente titulo="ListaBacklog" descripcion="Lista ordenable de historias (solo el PO puede arrastrar)." />
}
