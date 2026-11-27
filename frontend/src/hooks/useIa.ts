import { useMutation } from '@tanstack/react-query'
import * as iaApi from '../api/ia'

export function useGenerarHistorias(proyectoId: string) {
  return useMutation({ mutationFn: (idea: string) => iaApi.generarHistorias(proyectoId, idea) })
}

// TODO (Eliana): useGenerarCriterios, useSugerirEstimacion, useResumirSprint, useAceptarSugerencia, useChat.
