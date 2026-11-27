import axios from 'axios'

/** Instancia única de Axios para toda la app. */
export const cliente = axios.create({
  baseURL: import.meta.env.VITE_API_URL ?? '/api/v1',
  headers: { 'Content-Type': 'application/json' },
})

cliente.interceptors.request.use((config) => {
  // TODO (Eliana): leer el token de useSesionStore.getState().token y agregar Authorization: Bearer <token>.
  return config
})

cliente.interceptors.response.use(
  (respuesta) => respuesta,
  (error) => {
    // TODO (Eliana): ante 401 cerrar sesión y redirigir a /login; mostrar ProblemDetails.title en un Toast.
    return Promise.reject(error)
  },
)
