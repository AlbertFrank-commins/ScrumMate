import type { ReactNode } from 'react'
import Pendiente from '../../components/ui/Pendiente'

interface CardProps {
  children?: ReactNode
}

/**
 * Contenedor blanco con borde y sombra suave.
 * Responsable: Eliana (Módulo B).
 */
export default function Card(_props: CardProps) {
  // TODO (Eliana): implementar según la guía UI/UX.
  return <Pendiente titulo="Card" descripcion="Contenedor blanco con borde y sombra suave." />
}
