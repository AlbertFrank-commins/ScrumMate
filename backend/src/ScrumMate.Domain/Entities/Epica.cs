using ScrumMate.Domain.Common;

namespace ScrumMate.Domain.Entities;

/// <summary>Agrupador de historias. Tabla: epicas.</summary>
public class Epica : EntidadBase
{
    public Guid ProyectoId { get; private set; }
    public string Titulo { get; private set; } = string.Empty;
    public string? Descripcion { get; private set; }
    /// <summary>Color hexadecimal, por ejemplo "#7E22CE".</summary>
    public string Color { get; private set; } = "#4F46E5";

    private Epica() { } // EF Core

    public static Epica Crear(Guid proyectoId, string titulo, string? descripcion, string color)
    {
        // TODO (Albert)
        throw new NotImplementedException("Epica.Crear");
    }

    public void Renombrar(string titulo)
    {
        // TODO (Albert)
        throw new NotImplementedException("Epica.Renombrar");
    }
}
