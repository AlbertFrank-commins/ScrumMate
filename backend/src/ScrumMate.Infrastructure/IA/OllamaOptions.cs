namespace ScrumMate.Infrastructure.IA;

/// <summary>Sección "Ollama" (variables Ollama__BaseUrl, Ollama__Model, Ollama__RutaPrompts).</summary>
public sealed class OllamaOptions
{
    public const string Seccion = "Ollama";

    public string BaseUrl { get; set; } = "http://localhost:11434";
    public string Model { get; set; } = "qwen2.5:3b";
    public int TimeoutSegundos { get; set; } = 60;
    public string RutaPrompts { get; set; } = "prompts";
}
