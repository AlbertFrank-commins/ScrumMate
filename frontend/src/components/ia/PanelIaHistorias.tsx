import Pendiente from '../../components/ui/Pendiente'

interface PanelIaHistoriasProps {
  proyectoId: string
}

/**
 * Panel lateral: idea → Generar historias → sugerencias con Aceptar / Editar / Descartar.
 * Responsable: Eliana (Módulo B).
 */
export default function PanelIaHistorias(_props: PanelIaHistoriasProps) {
  // TODO (Eliana): useGenerarHistorias y aceptarSugerencia; nunca guardar sin Aceptar (RN-10).
  return <Pendiente titulo="PanelIaHistorias" descripcion="Panel lateral: idea → Generar historias → sugerencias con Aceptar / Editar / Descartar." />
}
