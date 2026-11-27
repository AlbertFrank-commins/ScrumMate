// Llamadas HTTP de auth. Usar `cliente` de ./cliente.
import type { Sesion, Usuario } from './tipos'

/** POST /auth/login */
export async function login(email: string, password: string): Promise<Sesion> {
  throw new Error('TODO (Eliana): POST /auth/login')
}

/** POST /auth/registro */
export async function registrar(nombre: string, email: string, password: string): Promise<Usuario> {
  throw new Error('TODO (Eliana): POST /auth/registro')
}

/** GET /auth/yo */
export async function obtenerYo(): Promise<Usuario> {
  throw new Error('TODO (Eliana): GET /auth/yo')
}
