import type { Velocidad } from '../../api/tipos'
import Pendiente from '../../components/ui/Pendiente'

interface GraficoVelocidadProps {
  datos: Velocidad[]
}

/**
 * Barras comprometido vs completado por sprint (Recharts).
 * Responsable: Eliana (Módulo B).
 */
export default function GraficoVelocidad(_props: GraficoVelocidadProps) {
  // TODO (Eliana): BarChart agrupado.
  return <Pendiente titulo="GraficoVelocidad" descripcion="Barras comprometido vs completado por sprint (Recharts)." />
}
