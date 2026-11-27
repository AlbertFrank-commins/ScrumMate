import { BrowserRouter, Navigate, Route, Routes } from 'react-router-dom'
import ProyectoLayout from '../components/layout/ProyectoLayout'
import AsistentePage from '../pages/AsistentePage'
import BacklogPage from '../pages/BacklogPage'
import ConfiguracionPage from '../pages/ConfiguracionPage'
import HistoriaDetallePage from '../pages/HistoriaDetallePage'
import LoginPage from '../pages/LoginPage'
import NoEncontradoPage from '../pages/NoEncontradoPage'
import PlanificarSprintPage from '../pages/PlanificarSprintPage'
import ProyectosPage from '../pages/ProyectosPage'
import RegistroPage from '../pages/RegistroPage'
import ReportesPage from '../pages/ReportesPage'
import SprintsPage from '../pages/SprintsPage'
import TableroPage from '../pages/TableroPage'
import RutaProtegida from './RutaProtegida'

/** Mapa de navegación: ver /docs/06-mapa-navegacion.md */
export default function AppRouter() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/login" element={<LoginPage />} />
        <Route path="/registro" element={<RegistroPage />} />

        <Route element={<RutaProtegida />}>
          <Route path="/proyectos" element={<ProyectosPage />} />
          <Route path="/proyectos/:id" element={<ProyectoLayout />}>
            <Route index element={<Navigate to="backlog" replace />} />
            <Route path="backlog" element={<BacklogPage />} />
            <Route path="sprints" element={<SprintsPage />} />
            <Route path="sprints/:sprintId/planificar" element={<PlanificarSprintPage />} />
            <Route path="tablero" element={<TableroPage />} />
            <Route path="historias/:historiaId" element={<HistoriaDetallePage />} />
            <Route path="reportes" element={<ReportesPage />} />
            <Route path="asistente" element={<AsistentePage />} />
            <Route path="configuracion" element={<ConfiguracionPage />} />
          </Route>
        </Route>

        <Route path="/" element={<Navigate to="/proyectos" replace />} />
        <Route path="*" element={<NoEncontradoPage />} />
      </Routes>
    </BrowserRouter>
  )
}
