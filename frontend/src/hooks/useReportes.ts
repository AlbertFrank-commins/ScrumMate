import { useQuery } from '@tanstack/react-query'
import * as reportesApi from '../api/reportes'

export function useBurndown(sprintId: string) {
  return useQuery({ queryKey: ['burndown', sprintId], queryFn: () => reportesApi.burndown(sprintId) })
}

export function useVelocidad(proyectoId: string) {
  return useQuery({ queryKey: ['velocidad', proyectoId], queryFn: () => reportesApi.velocidad(proyectoId) })
}
