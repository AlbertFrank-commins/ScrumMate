using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Reportes;

/// <summary>Puntos restantes por día contra la línea ideal. Rol: miembro.</summary>
public sealed record ObtenerBurndownQuery(Guid SprintId) : IRequest<BurndownDto>;

public sealed class ObtenerBurndownHandler : IRequestHandler<ObtenerBurndownQuery, BurndownDto>
{
    private readonly ISprintRepository _sprints;
    private readonly IHistorialEstadoRepository _historial;
    private readonly IAutorizacionProyecto _autorizacion;

    public ObtenerBurndownHandler(ISprintRepository sprints, IHistorialEstadoRepository historial, IAutorizacionProyecto autorizacion)
    {
        _sprints = sprints;
        _historial = historial;
        _autorizacion = autorizacion;
    }

    public Task<BurndownDto> Handle(ObtenerBurndownQuery request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Calcular desde historial_estados día por día entre FechaInicio y FechaFin.
        throw new NotImplementedException("ObtenerBurndownQuery");
    }
}
