namespace ScrumMate.IntegrationTests.Endpoints;

public class SprintsEndpointsTests : IClassFixture<ApiFactory>
{
    private readonly ApiFactory _factory;

    public SprintsEndpointsTests(ApiFactory factory)
    {
        _factory = factory;
    }

    [Fact(Skip = "Pendiente: RN-01")]
    public void IniciarSegundoSprint_Devuelve409()
    {
        // TODO (Albert)
    }
}
