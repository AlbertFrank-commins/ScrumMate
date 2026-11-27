import { useQuery } from '@tanstack/react-query'
import * as sprintsApi from '../api/sprints'

export function useSprints(proyectoId: string) {
  return useQuery({ queryKey: ['sprints', proyectoId], queryFn: () => sprintsApi.listar(proyectoId) })
}

// TODO (Eliana): useCrearSprint, useIniciarSprint, useCerrarSprint, useAgregarHistoriaASprint.
