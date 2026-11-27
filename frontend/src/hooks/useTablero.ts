import { useQuery } from '@tanstack/react-query'
import * as sprintsApi from '../api/sprints'

export function useTablero(sprintId: string) {
  return useQuery({ queryKey: ['tablero', sprintId], queryFn: () => sprintsApi.obtenerTablero(sprintId) })
}

// TODO (Eliana): useMoverHistoria con actualización optimista y reversión si la API responde 409 (RN-07).
