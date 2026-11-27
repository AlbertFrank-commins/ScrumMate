# ScrumMate

Gestor de proyectos Scrum con un asistente de IA local (Ollama). Proyecto final de **Software Configuration Management I**.

> Este repositorio es el **esqueleto** del proyecto: todas las carpetas, clases, interfaces y métodos ya existen,
> pero los métodos están vacíos (`throw new NotImplementedException` / `throw new Error('TODO')`).
> Cada `TODO (Nombre)` indica quién lo implementa y qué debe hacer. Busca `TODO (` en VS Code para ver tu trabajo.

## Módulos y responsables

| Módulo | Responsable | Carpetas |
| --- | --- | --- |
| A · Backend, base de datos e IA | Albert | `backend/`, `prompts/` |
| B · Frontend y UX | Eliana | `frontend/`, `design/` |
| C · DevOps, QA y Scrum Master | Ezequiel | `k8s/`, `.github/`, `e2e/`, `docker-compose.yml` |
| Documentación | Los tres (cada quien la suya) | `docs/` |

El detalle de cada módulo (clases, métodos, endpoints, reglas) está en el *Manual de Módulos y Responsabilidades*.

## Estructura

```
ScrumMate/
├── backend/                         # Módulo A · .NET 8
│   ├── ScrumMate.sln
│   ├── src/
│   │   ├── ScrumMate.Domain/        # Entidades, enums, reglas de negocio (sin dependencias)
│   │   ├── ScrumMate.Application/   # Casos de uso (MediatR), DTOs, validadores, interfaces, servicio IA
│   │   │   └── Features/            # Auth, Proyectos, Backlog, Sprints, Kanban, Reportes, Ia
│   │   ├── ScrumMate.Infrastructure/# EF Core + PostgreSQL, repositorios, JWT, BCrypt, Ollama
│   │   └── ScrumMate.Api/           # Controllers, middleware, Program.cs
│   └── tests/
│       ├── ScrumMate.UnitTests/
│       └── ScrumMate.IntegrationTests/
├── prompts/                         # Módulo A · plantillas del LLM versionadas
├── frontend/                        # Módulo B · React + TypeScript + Vite + Tailwind
│   └── src/
│       ├── api/                     # Llamadas HTTP por recurso + tipos
│       ├── hooks/                   # TanStack Query
│       ├── store/                   # Zustand (sesión, proyecto activo)
│       ├── components/              # ui/, layout/, backlog/, kanban/, ia/, reportes/, auth/
│       ├── pages/                   # Una pantalla por ruta
│       ├── routes/                  # AppRouter y RutaProtegida
│       ├── lib/                     # Constantes, permisos, formato
│       └── mocks/                   # MSW (API simulada)
├── design/                          # Módulo B · exportes de Figma
├── e2e/                             # Módulo C · Playwright
├── k8s/                             # Módulo C · Kustomize (base + overlays staging/demo)
├── .github/                         # Módulo C · workflows, plantillas de PR/issues, CODEOWNERS
├── docs/                            # PRD, historias, reglas, especificación, BD, navegación, UI/UX, pruebas, ADR, RFC
├── docker-compose.yml
└── .env.example
```

## Requisitos

- .NET SDK 8 · Node.js 20+ · Docker Desktop · Git
- Ollama (opcional en local; en Docker ya viene)
- kind o minikube + kubectl (solo para Kubernetes)

## Primeros pasos (solo una vez, lo hace Ezequiel)

```bash
git init -b main
git add .
git commit -m "chore: estructura inicial del proyecto"
git branch develop
git remote add origin https://github.com/<organizacion>/scrummate.git
git push -u origin main develop
```

Luego en GitHub: proteger `main` y `develop` (PR obligatorio, 1 aprobación, CI en verde) y reemplazar los usuarios de `.github/CODEOWNERS`.

## Cómo correrlo

**Todo con Docker:**

```bash
cp .env.example .env
docker compose up -d
# Web: http://localhost:5173 · API: http://localhost:5080/swagger
```

**Backend en local:**

```bash
cd backend
dotnet build
dotnet test
dotnet run --project src/ScrumMate.Api   # http://localhost:5080/swagger
```

**Frontend en local:**

```bash
cd frontend
npm install
npm run dev    # http://localhost:5173
```

## Convenciones

- Ramas: `feature/<issue>-<nombre>` desde `develop`; `release/<versión>` al cierre del sprint.
- Commits: Conventional Commits con ámbito, por ejemplo `feat(api): crear endpoint de sprints`.
- Todo cambio entra por PR con la plantilla y `Closes #<issue>`.
- Cambios que afectan a más de un módulo: RFC en `docs/rfc/` antes de programar.

## Pendientes de esqueleto

- El script `lint` del frontend no usa `--max-warnings 0` todavía, porque los métodos vacíos generan avisos. Agrégalo cuando el módulo B esté implementado.
- Las pruebas están marcadas como `Skip` / `todo` / `fixme` hasta que exista la lógica.
