namespace ScrumMate.Domain.Common;

/// <summary>
/// Clase base de todas las entidades con identidad propia.
/// </summary>
public abstract class EntidadBase
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public DateTime CreadoEn { get; protected set; } = DateTime.UtcNow;
    public DateTime ActualizadoEn { get; protected set; } = DateTime.UtcNow;

    /// <summary>Lo llama AppDbContext al guardar cambios.</summary>
    public void MarcarActualizado() => ActualizadoEn = DateTime.UtcNow;
}
