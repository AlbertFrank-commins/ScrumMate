namespace ScrumMate.IntegrationTests.Endpoints;

public class AuthEndpointsTests : IClassFixture<ApiFactory>
{
    private readonly ApiFactory _factory;

    public AuthEndpointsTests(ApiFactory factory)
    {
        _factory = factory;
    }

    [Fact(Skip = "Pendiente: registro y login")]
    public void Registro_Y_Login_DevuelveToken()
    {
        // TODO (Albert)
    }
}
