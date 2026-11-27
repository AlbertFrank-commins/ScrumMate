import Pendiente from '../../components/ui/Pendiente'

interface InputProps {
  label: string
  error?: string
}

/**
 * Campo de texto con etiqueta y mensaje de error.
 * Responsable: Eliana (Módulo B).
 */
export default function Input(_props: InputProps) {
  // TODO (Eliana): implementar según la guía UI/UX.
  return <Pendiente titulo="Input" descripcion="Campo de texto con etiqueta y mensaje de error." />
}
