using FluentValidation;
using MediatR;

namespace ScrumMate.Application.Common.Behaviors;

/// <summary>Ejecuta los validadores de FluentValidation antes de cada handler.</summary>
public sealed class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        // TODO (Albert): ejecutar _validators y lanzar ValidationException si hay errores.
        return await next();
    }
}
