interface PendienteProps {
  titulo: string
  descripcion?: string
}

/** Marcador temporal para pantallas y componentes aún sin implementar. Borrar al terminar. */
export default function Pendiente({ titulo, descripcion }: PendienteProps) {
  return (
    <div className="rounded-tarjeta border-2 border-dashed border-indigo-300 bg-white p-6 text-slate-600">
      <p className="text-sm font-semibold text-primario">Pendiente</p>
      <p className="text-lg font-semibold text-slate-900">{titulo}</p>
      {descripcion && <p className="mt-1 text-sm">{descripcion}</p>}
    </div>
  )
}
