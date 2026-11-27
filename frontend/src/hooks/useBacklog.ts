import { useQuery } from '@tanstack/react-query'
import * as historiasApi from '../api/historias'

export function useBacklog(proyectoId: string) {
  return useQuery({ queryKey: ['backlog', proyectoId], queryFn: () => historiasApi.listarBacklog(proyectoId) })
}

export function useHistoria(historiaId: string) {
  return useQuery({ queryKey: ['historia', historiaId], queryFn: () => historiasApi.obtener(historiaId) })
}

// TODO (Eliana): useCrearHistoria, useEstimar, useReordenarBacklog con useMutation.
