using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Sprints;

/// <summary>Detalle de un sprint. Rol: miembro.</summary>
public sealed record ObtenerSprintQuery(Guid SprintId) : IRequest<SprintDto>;

public sealed class ObtenerSprintHandler : IRequestHandler<ObtenerSprintQuery, SprintDto>
{
    private readonly ISprintRepository _sprints;
    private readonly IAutorizacionProyecto _autorizacion;

    public ObtenerSprintHandler(ISprintRepository sprints, IAutorizacionProyecto autorizacion)
    {
        _sprints = sprints;
        _autorizacion = autorizacion;
    }

    public Task<SprintDto> Handle(ObtenerSprintQuery request, CancellationToken cancellationToken)
    {
        // TODO (Albert): ObtenerConHistoriasAsync y mapear con puntos.
        throw new NotImplementedException("ObtenerSprintQuery");
    }
}
