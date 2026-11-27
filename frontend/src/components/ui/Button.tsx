import type { ButtonHTMLAttributes } from 'react'

interface ButtonProps extends ButtonHTMLAttributes<HTMLButtonElement> {
  variante?: 'primario' | 'secundario' | 'texto'
  cargando?: boolean
}

export default function Button({ variante = 'primario', cargando = false, children, ...props }: ButtonProps) {
  // TODO (Eliana): estilos por variante según la guía UI/UX y Spinner cuando cargando.
  return (
    <button className="rounded-lg bg-primario px-4 py-2.5 text-sm font-semibold text-white" disabled={cargando} {...props}>
      {children}
    </button>
  )
}
