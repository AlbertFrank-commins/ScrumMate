import type { Burndown } from '../../api/tipos'
import Pendiente from '../../components/ui/Pendiente'

interface GraficoBurndownProps {
  datos: Burndown
}

/**
 * Línea real contra línea ideal (Recharts).
 * Responsable: Eliana (Módulo B).
 */
export default function GraficoBurndown(_props: GraficoBurndownProps) {
  // TODO (Eliana): LineChart con dos series.
  return <Pendiente titulo="GraficoBurndown" descripcion="Línea real contra línea ideal (Recharts)." />
}
