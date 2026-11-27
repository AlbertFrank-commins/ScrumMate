import type { ReactNode } from 'react'
import type { Accion } from '../../lib/permisos'

interface GuardRolProps {
  accion: Accion
  children: ReactNode
}

/** Muestra children solo si el rol actual puede hacer la acción. */
export default function GuardRol({ children }: GuardRolProps) {
  // TODO (Eliana): usar puede(useProyectoStore().rolActual, accion) y devolver null si no puede.
  return <>{children}</>
}
