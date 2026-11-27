import type { CrearHistoriaDto, Historia } from '../../api/tipos'
import Pendiente from '../../components/ui/Pendiente'

interface FormHistoriaProps {
  historiaInicial?: Historia
  onGuardar: (dto: CrearHistoriaDto) => void
}

/**
 * Formulario de historia con React Hook Form + Zod.
 * Responsable: Eliana (Módulo B).
 */
export default function FormHistoria(_props: FormHistoriaProps) {
  // TODO (Eliana): campos título, descripción, prioridad y épica.
  return <Pendiente titulo="FormHistoria" descripcion="Formulario de historia con React Hook Form + Zod." />
}
