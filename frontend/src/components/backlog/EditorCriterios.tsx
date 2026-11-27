import type { Criterio } from '../../api/tipos'
import Pendiente from '../../components/ui/Pendiente'

interface EditorCriteriosProps {
  criterios: Criterio[]
  onAgregar: (dado: string, cuando: string, entonces: string) => void
  onMarcar: (id: string, cumplido: boolean) => void
}

/**
 * Lista y alta de criterios Dado / Cuando / Entonces.
 * Responsable: Eliana (Módulo B).
 */
export default function EditorCriterios(_props: EditorCriteriosProps) {
  // TODO (Eliana): checkbox para marcar cumplido.
  return <Pendiente titulo="EditorCriterios" descripcion="Lista y alta de criterios Dado / Cuando / Entonces." />
}
