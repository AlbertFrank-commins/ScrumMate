using FluentValidation;
using MediatR;
using ScrumMate.Application.Common.Interfaces;
using ScrumMate.Domain.Enums;

namespace ScrumMate.Application.Features.Proyectos;

/// <summary>Lista los proyectos donde el usuario es miembro.</summary>
public sealed record ListarMisProyectosQuery() : IRequest<IReadOnlyList<ProyectoResumenDto>>;

public sealed class ListarMisProyectosHandler : IRequestHandler<ListarMisProyectosQuery, IReadOnlyList<ProyectoResumenDto>>
{
    private readonly IProyectoRepository _proyectos;
    private readonly IUsuarioActual _usuarioActual;

    public ListarMisProyectosHandler(IProyectoRepository proyectos, IUsuarioActual usuarioActual)
    {
        _proyectos = proyectos;
        _usuarioActual = usuarioActual;
    }

    public Task<IReadOnlyList<ProyectoResumenDto>> Handle(ListarMisProyectosQuery request, CancellationToken cancellationToken)
    {
        // TODO (Albert): IProyectoRepository.ListarPorUsuarioAsync y mapear.
        throw new NotImplementedException("ListarMisProyectosQuery");
    }
}
