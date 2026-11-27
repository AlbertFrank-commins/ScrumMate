namespace ScrumMate.Infrastructure.Auth;

/// <summary>Sección "Jwt" de la configuración (variables Jwt__Secret, Jwt__Issuer...).</summary>
public sealed class JwtOptions
{
    public const string Seccion = "Jwt";

    public string Secret { get; set; } = string.Empty;
    public string Issuer { get; set; } = "scrummate";
    public string Audience { get; set; } = "scrummate-web";
    public int ExpiracionMinutos { get; set; } = 480;
}
