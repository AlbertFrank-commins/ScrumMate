using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Application.Features.Backlog;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Kanban;

/// <summary>Tablero del sprint agrupado por estado. Rol: miembro.</summary>
public sealed record ObtenerTableroQuery(Guid SprintId) : IRequest<TableroDto>;

public sealed class ObtenerTableroHandler : IRequestHandler<ObtenerTableroQuery, TableroDto>
{
    private readonly ISprintRepository _sprints;
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;

    public ObtenerTableroHandler(ISprintRepository sprints, IHistoriaRepository historias, IAutorizacionProyecto autorizacion)
    {
        _sprints = sprints;
        _historias = historias;
        _autorizacion = autorizacion;
    }

    public Task<TableroDto> Handle(ObtenerTableroQuery request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Agrupar ListarPorSprintAsync en 4 columnas con suma de puntos.
        throw new NotImplementedException("ObtenerTableroQuery");
    }
}
