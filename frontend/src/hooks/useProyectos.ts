import { useQuery } from '@tanstack/react-query'
import * as proyectosApi from '../api/proyectos'

export function useProyectos() {
  return useQuery({ queryKey: ['proyectos'], queryFn: proyectosApi.listar })
}

export function useProyecto(id: string) {
  return useQuery({ queryKey: ['proyectos', id], queryFn: () => proyectosApi.obtener(id) })
}

// TODO (Eliana): useCrearProyecto, useAgregarMiembro… con useMutation + invalidateQueries(['proyectos']).
