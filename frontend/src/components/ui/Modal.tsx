import type { ReactNode } from 'react'
import Pendiente from '../../components/ui/Pendiente'

interface ModalProps {
  abierto: boolean
  titulo: string
  onCerrar: () => void
  children?: ReactNode
}

/**
 * Diálogo modal accesible (cierra con Esc).
 * Responsable: Eliana (Módulo B).
 */
export default function Modal(_props: ModalProps) {
  // TODO (Eliana): implementar según la guía UI/UX.
  return <Pendiente titulo="Modal" descripcion="Diálogo modal accesible (cierra con Esc)." />
}
