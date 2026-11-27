using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Backlog;

/// <summary>Detalle de una historia con criterios. Rol: miembro.</summary>
public sealed record ObtenerHistoriaQuery(Guid HistoriaId) : IRequest<HistoriaDetalleDto>;

public sealed class ObtenerHistoriaHandler : IRequestHandler<ObtenerHistoriaQuery, HistoriaDetalleDto>
{
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;

    public ObtenerHistoriaHandler(IHistoriaRepository historias, IAutorizacionProyecto autorizacion)
    {
        _historias = historias;
        _autorizacion = autorizacion;
    }

    public Task<HistoriaDetalleDto> Handle(ObtenerHistoriaQuery request, CancellationToken cancellationToken)
    {
        // TODO (Albert): ObtenerConCriteriosAsync y mapear.
        throw new NotImplementedException("ObtenerHistoriaQuery");
    }
}
