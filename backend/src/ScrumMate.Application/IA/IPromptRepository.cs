namespace ScrumMate.Application.IA;

/// <summary>Carga las plantillas versionadas de /prompts (por ejemplo "generar-historias.v1").</summary>
public interface IPromptRepository
{
    string ObtenerPlantilla(string nombre);

    /// <summary>Reemplaza {{variable}} en la plantilla por los valores dados.</summary>
    string Renderizar(string nombre, IReadOnlyDictionary<string, string> variables);
}
