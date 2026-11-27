import type { Historia } from '../../api/tipos'
import Pendiente from '../../components/ui/Pendiente'

interface TarjetaHistoriaProps {
  historia: Historia
  onClick?: () => void
}

/**
 * Tarjeta de historia (igual al componente TarjetaHistoria de Figma).
 * Responsable: Eliana (Módulo B).
 */
export default function TarjetaHistoria(_props: TarjetaHistoriaProps) {
  // TODO (Eliana): código, título, prioridad, puntos e iniciales.
  return <Pendiente titulo="TarjetaHistoria" descripcion="Tarjeta de historia (igual al componente TarjetaHistoria de Figma)." />
}
