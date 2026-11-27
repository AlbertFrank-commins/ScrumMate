import { Outlet } from 'react-router-dom'

/** Redirige a /login si no hay sesión. */
export default function RutaProtegida() {
  // TODO (Eliana): si !useSesionStore().token → <Navigate to="/login" replace />
  return <Outlet />
}
