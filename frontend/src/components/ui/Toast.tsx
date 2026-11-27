import Pendiente from '../../components/ui/Pendiente'

interface ToastProps {
  mensaje: string
  tipo?: 'exito' | 'error'
}

/**
 * Notificación temporal.
 * Responsable: Eliana (Módulo B).
 */
export default function Toast(_props: ToastProps) {
  // TODO (Eliana): implementar según la guía UI/UX.
  return <Pendiente titulo="Toast" descripcion="Notificación temporal." />
}
