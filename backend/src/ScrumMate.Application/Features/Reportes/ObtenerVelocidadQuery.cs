using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Reportes;

/// <summary>Puntos comprometidos y completados por sprint cerrado. Rol: miembro.</summary>
public sealed record ObtenerVelocidadQuery(Guid ProyectoId) : IRequest<IReadOnlyList<VelocidadDto>>;

public sealed class ObtenerVelocidadHandler : IRequestHandler<ObtenerVelocidadQuery, IReadOnlyList<VelocidadDto>>
{
    private readonly ISprintRepository _sprints;
    private readonly IAutorizacionProyecto _autorizacion;

    public ObtenerVelocidadHandler(ISprintRepository sprints, IAutorizacionProyecto autorizacion)
    {
        _sprints = sprints;
        _autorizacion = autorizacion;
    }

    public Task<IReadOnlyList<VelocidadDto>> Handle(ObtenerVelocidadQuery request, CancellationToken cancellationToken)
    {
        // TODO (Albert): Recorrer sprints cerrados y sumar puntos.
        throw new NotImplementedException("ObtenerVelocidadQuery");
    }
}
