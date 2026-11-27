import { create } from 'zustand'
import type { Usuario } from '../api/tipos'

interface SesionState {
  token: string | null
  usuario: Usuario | null
  iniciarSesion: (token: string, usuario: Usuario) => void
  cerrarSesion: () => void
}

// TODO (Eliana): persistir el token en localStorage con el middleware `persist` de zustand.
export const useSesionStore = create<SesionState>((set) => ({
  token: null,
  usuario: null,
  iniciarSesion: (token, usuario) => set({ token, usuario }),
  cerrarSesion: () => set({ token: null, usuario: null }),
}))
