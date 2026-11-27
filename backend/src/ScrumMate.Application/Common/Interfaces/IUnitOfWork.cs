namespace ScrumMate.Application.Common.Interfaces;

/// <summary>Confirma todos los cambios de un caso de uso en una sola transacción.</summary>
public interface IUnitOfWork
{
    Task<int> GuardarCambiosAsync(CancellationToken ct = default);
}
