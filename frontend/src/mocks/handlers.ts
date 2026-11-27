import { http, HttpResponse } from 'msw'

/** API simulada mientras el endpoint real no exista (Módulo A lo marca como listo en el issue). */
export const handlers = [
  http.get('/api/v1/proyectos', () =>
    HttpResponse.json([
      { id: '1', nombre: 'ScrumMate', descripcion: 'Proyecto demo', miRol: 'ProductOwner', cantidadMiembros: 3 },
    ]),
  ),
  // TODO (Eliana): agregar handlers para backlog, sprints, tablero e IA.
]
