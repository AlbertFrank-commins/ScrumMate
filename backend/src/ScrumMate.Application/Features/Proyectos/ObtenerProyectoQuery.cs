using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Proyectos;

/// <summary>Detalle de un proyecto con sus miembros. Rol: miembro.</summary>
public sealed record ObtenerProyectoQuery(Guid ProyectoId) : IRequest<ProyectoDetalleDto>;

public sealed class ObtenerProyectoHandler : IRequestHandler<ObtenerProyectoQuery, ProyectoDetalleDto>
{
    private readonly IProyectoRepository _proyectos;
    private readonly IAutorizacionProyecto _autorizacion;

    public ObtenerProyectoHandler(IProyectoRepository proyectos, IAutorizacionProyecto autorizacion)
    {
        _proyectos = proyectos;
        _autorizacion = autorizacion;
    }

    public Task<ProyectoDetalleDto> Handle(ObtenerProyectoQuery request, CancellationToken cancellationToken)
    {
        // TODO (Albert): ExigirMiembroAsync y ObtenerConMiembrosAsync.
        throw new NotImplementedException("ObtenerProyectoQuery");
    }
}
