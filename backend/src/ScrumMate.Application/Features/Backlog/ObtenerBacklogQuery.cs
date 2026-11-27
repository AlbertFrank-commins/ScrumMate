using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Backlog;

/// <summary>Historias del proyecto ordenadas por OrdenBacklog. Rol: miembro.</summary>
public sealed record ObtenerBacklogQuery(Guid ProyectoId) : IRequest<IReadOnlyList<HistoriaDto>>;

public sealed class ObtenerBacklogHandler : IRequestHandler<ObtenerBacklogQuery, IReadOnlyList<HistoriaDto>>
{
    private readonly IHistoriaRepository _historias;
    private readonly IAutorizacionProyecto _autorizacion;

    public ObtenerBacklogHandler(IHistoriaRepository historias, IAutorizacionProyecto autorizacion)
    {
        _historias = historias;
        _autorizacion = autorizacion;
    }

    public Task<IReadOnlyList<HistoriaDto>> Handle(ObtenerBacklogQuery request, CancellationToken cancellationToken)
    {
        // TODO (Albert): ListarBacklogAsync y mapear.
        throw new NotImplementedException("ObtenerBacklogQuery");
    }
}
