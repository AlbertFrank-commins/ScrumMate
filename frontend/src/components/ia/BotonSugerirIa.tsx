import Pendiente from '../../components/ui/Pendiente'

interface BotonSugerirIaProps {
  tipo: 'criterios' | 'estimacion'
  historiaId: string
}

/**
 * Botón que pide criterios o estimación a la IA.
 * Responsable: Eliana (Módulo B).
 */
export default function BotonSugerirIa(_props: BotonSugerirIaProps) {
  // TODO (Eliana): mostrar resultado con EtiquetaSugeridoIa.
  return <Pendiente titulo="BotonSugerirIa" descripcion="Botón que pide criterios o estimación a la IA." />
}
