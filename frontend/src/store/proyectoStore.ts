import { create } from 'zustand'
import type { RolProyecto } from '../api/tipos'

interface ProyectoState {
  proyectoActivoId: string | null
  rolActual: RolProyecto | null
  seleccionarProyecto: (id: string, rol: RolProyecto) => void
}

export const useProyectoStore = create<ProyectoState>((set) => ({
  proyectoActivoId: null,
  rolActual: null,
  seleccionarProyecto: (id, rol) => set({ proyectoActivoId: id, rolActual: rol }),
}))
