using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Backlog;

/// <summary>Lista las épicas del proyecto. Rol: miembro.</summary>
public sealed record ListarEpicasQuery(Guid ProyectoId) : IRequest<IReadOnlyList<EpicaDto>>;

public sealed class ListarEpicasHandler : IRequestHandler<ListarEpicasQuery, IReadOnlyList<EpicaDto>>
{
    private readonly IEpicaRepository _epicas;
    private readonly IAutorizacionProyecto _autorizacion;

    public ListarEpicasHandler(IEpicaRepository epicas, IAutorizacionProyecto autorizacion)
    {
        _epicas = epicas;
        _autorizacion = autorizacion;
    }

    public Task<IReadOnlyList<EpicaDto>> Handle(ListarEpicasQuery request, CancellationToken cancellationToken)
    {
        // TODO (Albert): ListarPorProyectoAsync y mapear.
        throw new NotImplementedException("ListarEpicasQuery");
    }
}
