import Pendiente from '../../components/ui/Pendiente'

interface ChatAsistenteProps {
  proyectoId: string
}

/**
 * Chat con respuesta en streaming y preguntas sugeridas.
 * Responsable: Eliana (Módulo B).
 */
export default function ChatAsistente(_props: ChatAsistenteProps) {
  // TODO (Eliana): iaApi.chat con onFragmento para ir pintando la respuesta.
  return <Pendiente titulo="ChatAsistente" descripcion="Chat con respuesta en streaming y preguntas sugeridas." />
}
