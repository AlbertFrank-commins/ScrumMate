using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Sprints;

/// <summary>Sprints del proyecto. Rol: miembro.</summary>
public sealed record ListarSprintsQuery(Guid ProyectoId) : IRequest<IReadOnlyList<SprintDto>>;

public sealed class ListarSprintsHandler : IRequestHandler<ListarSprintsQuery, IReadOnlyList<SprintDto>>
{
    private readonly ISprintRepository _sprints;
    private readonly IAutorizacionProyecto _autorizacion;

    public ListarSprintsHandler(ISprintRepository sprints, IAutorizacionProyecto autorizacion)
    {
        _sprints = sprints;
        _autorizacion = autorizacion;
    }

    public Task<IReadOnlyList<SprintDto>> Handle(ListarSprintsQuery request, CancellationToken cancellationToken)
    {
        // TODO (Albert): ListarPorProyectoAsync y mapear.
        throw new NotImplementedException("ListarSprintsQuery");
    }
}
