import Pendiente from '../../components/ui/Pendiente'

interface SelectorPuntosProps {
  valor?: number
  onCambiar: (puntos: number) => void
}

/**
 * Botones 1, 2, 3, 5, 8, 13, 21 (RN-04).
 * Responsable: Eliana (Módulo B).
 */
export default function SelectorPuntos(_props: SelectorPuntosProps) {
  // TODO (Eliana): usar PUNTOS_FIBONACCI de lib/constantes.
  return <Pendiente titulo="SelectorPuntos" descripcion="Botones 1, 2, 3, 5, 8, 13, 21 (RN-04)." />
}
