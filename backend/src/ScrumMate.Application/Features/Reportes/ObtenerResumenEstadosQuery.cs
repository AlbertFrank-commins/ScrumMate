using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Reportes;

/// <summary>Cantidad de historias por estado. Rol: miembro.</summary>
public sealed record ObtenerResumenEstadosQuery(Guid ProyectoId) : IRequest<ResumenEstadosDto>;

public sealed class ObtenerResumenEstadosHandler : IRequestHandler<ObtenerResumenEstadosQuery, ResumenEstadosDto>
{
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;

    public ObtenerResumenEstadosHandler(IHistoriaRepository historias, IAutorizacionProyecto autorizacion)
    {
        _historias = historias;
        _autorizacion = autorizacion;
    }

    public Task<ResumenEstadosDto> Handle(ObtenerResumenEstadosQuery request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Contar por Estado.
        throw new NotImplementedException("ObtenerResumenEstadosQuery");
    }
}
