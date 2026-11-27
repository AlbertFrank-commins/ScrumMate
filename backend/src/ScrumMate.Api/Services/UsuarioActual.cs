using ScrumMate.Application.Common.Interfaces;

namespace ScrumMate.Api.Services;

/// <summary>Lee el claim "sub" del JWT del request actual.</summary>
public sealed class UsuarioActual : IUsuarioActual
{
    private readonly IHttpContextAccessor _accessor;

    public UsuarioActual(IHttpContextAccessor accessor)
    {
        _accessor = accessor;
    }

    public Guid Id => throw new NotImplementedException("TODO (Albert): Guid.Parse del claim sub.");

    public bool EstaAutenticado => _accessor.HttpContext?.User.Identity?.IsAuthenticated ?? false;
}
