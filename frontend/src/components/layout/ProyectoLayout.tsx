import { Outlet } from 'react-router-dom'
import BarraLateral from './BarraLateral'

/** Layout de todas las pantallas dentro de un proyecto: barra lateral + contenido. */
export default function ProyectoLayout() {
  return (
    <div className="flex min-h-screen">
      <aside className="w-62 shrink-0 bg-lateral p-4 text-white">
        <BarraLateral />
      </aside>
      <main className="flex-1 p-8">
        <Outlet />
      </main>
    </div>
  )
}
