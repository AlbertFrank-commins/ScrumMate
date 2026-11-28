# Líneas base

**Responsable:** Ezequiel (Scrum Master y gestión de configuración) · **Apoyo:** Albert y Eliana

Una línea base es una versión aprobada y congelada de un conjunto de elementos de configuración. Sirve como punto de referencia: a partir de ella, cualquier cambio pasa por el control de cambios (RFC).

## 1. Qué es una línea base en ScrumMate

- Es un **tag de Git** sobre un commit de `main`, acompañado de un **GitHub Release** con su nota.
- Solo se crea desde `main`, después de un Pull Request aprobado desde `develop` o `release/*`.
- **La aprueban los tres integrantes.** Cada uno revisa los elementos de su módulo y aprueba el PR.
- Una vez creada, una línea base **no se modifica**. Un cambio genera una línea base nueva con otro tag.

## 2. Elementos de configuración (CI)

| ID | Elemento | Ubicación | Responsable | Línea base |
| --- | --- | --- | --- | --- |
| CI-DOC-01 | PRD | `docs/01-prd.md` | Los tres | LB-0 |
| CI-DOC-02 | Historias de usuario | `docs/02-historias.md` + Issues | Eliana | LB-0 |
| CI-DOC-03 | Reglas de negocio | `docs/03-reglas-negocio.md` | Albert | LB-0 |
| CI-DOC-04 | Especificación técnica | `docs/04-especificacion-tecnica.md` | Albert | LB-1 |
| CI-DOC-05 | Diseño de base de datos | `docs/05-base-de-datos.md` | Albert | LB-1 |
| CI-DOC-06 | Mapa de navegación | `docs/06-mapa-navegacion.md` | Eliana | LB-1 |
| CI-DOC-07 | Guía UI/UX y mockups | `docs/07-guia-ui-ux.md`, `design/` | Eliana | LB-1 |
| CI-DOC-08 | ADR | `docs/adr/` | Los tres | LB-1 |
| CI-DOC-09 | Plan de pruebas | `docs/08-plan-pruebas.md` | Ezequiel | LB-2 |
| CI-DOC-10 | Plan de implementación | `docs/09-plan-implementacion.md` | Ezequiel | LB-3 |
| CI-DOC-11 | Guía de despliegue | `docs/10-guia-despliegue.md` | Ezequiel | LB-3 |
| CI-COD-01 | Backend (API, dominio, aplicación, infraestructura) | `backend/src/` | Albert | LB-2 |
| CI-COD-02 | Migraciones de base de datos | `backend/src/ScrumMate.Infrastructure/Persistence/Migrations/` | Albert | LB-2 |
| CI-COD-03 | Prompts del LLM | `prompts/` | Albert | LB-2 |
| CI-COD-04 | Frontend | `frontend/src/` | Eliana | LB-2 |
| CI-COD-05 | Pruebas unitarias y de integración | `backend/tests/`, `frontend/src/**/*.test.tsx` | Albert, Eliana | LB-2 |
| CI-COD-06 | Pruebas E2E | `e2e/` | Ezequiel | LB-2 |
| CI-INF-01 | Dockerfiles y Docker Compose | `backend/Dockerfile`, `frontend/Dockerfile`, `docker-compose.yml` | Ezequiel | LB-2 |
| CI-INF-02 | Manifiestos de Kubernetes | `k8s/` | Ezequiel | LB-3 |
| CI-INF-03 | Pipelines CI/CD | `.github/workflows/` | Ezequiel | LB-2 |
| CI-INF-04 | Configuración del repositorio | `.gitignore`, `.gitattributes`, `.editorconfig`, `.github/CODEOWNERS`, `.env.example` | Ezequiel | LB-0 |

**No son elementos de configuración:** `bin/`, `obj/`, `node_modules/`, `dist/`, el archivo `.env`, los reportes de pruebas y de cobertura, y las imágenes Docker. Todos se generan a partir de los elementos anteriores.

## 3. Líneas base del proyecto

| Línea base | Cuándo | Qué congela | Tag en Git |
| --- | --- | --- | --- |
| LB-0 Funcional | Cierre del Sprint 0 | PRD, historias de usuario, reglas de negocio, configuración del repositorio | `lb-0-funcional` |
| LB-1 Diseño | Cierre del Sprint 1 | Especificación técnica, diseño de BD, mapa de navegación, guía UI/UX, ADR | `lb-1-diseno` |
| LB-2 Desarrollo | Cierre de cada sprint | Código estable de `develop`, migraciones, prompts, pruebas, Docker y CI/CD | `v0.1.0`, `v0.2.0`, … |
| LB-3 Producto | Entrega final | Versión completa desplegada en Kubernetes, con toda la documentación | `v1.0.0` |

## 4. Cómo se crea una línea base

1. Verificar que `develop` tiene el CI en verde y que los elementos de la línea base están completos.
2. Abrir un Pull Request de `develop` hacia `main` con el título `Línea base LB-X: <nombre>`.
3. Los tres integrantes revisan y aprueban el PR, y luego se fusiona.
4. Crear el tag con su nota sobre `main`:
   ```bash
   git switch main
   git pull
   git tag -a lb-0-funcional -m "LB-0 Funcional: PRD, historias, reglas de negocio"
   git push origin lb-0-funcional
   ```
5. En GitHub, ir a **Releases → Draft a new release**, elegir el tag y escribir qué contiene.
6. Anotar la línea base en el registro (sección 6).

## 5. Cómo se cambia algo ya aprobado

1. Quien necesita el cambio escribe una RFC en `docs/rfc/` (plantilla `RFC-000-plantilla.md`) con el problema, la propuesta y su impacto.
2. Se discute en el daily y los tres votan en la RFC.
3. Si se aprueba, el cambio se hace en una rama `feature/*` o `fix/*` y entra por PR a `develop`.
4. El documento modificado anota su versión nueva y la RFC que lo originó.
5. El cambio queda congelado en la **siguiente** línea base, con un tag nuevo. El tag anterior no se toca.

## 6. Registro de líneas base

| Fecha | Línea base | Tag | Contenido | Aprobaron | RFC incluidas |
| --- | --- | --- | --- | --- | --- |
| | LB-0 Funcional | `lb-0-funcional` | | | |
| | LB-1 Diseño | `lb-1-diseno` | | | |
| | LB-2 Desarrollo | `v0.1.0` | | | |
| | LB-3 Producto | `v1.0.0` | | | |
