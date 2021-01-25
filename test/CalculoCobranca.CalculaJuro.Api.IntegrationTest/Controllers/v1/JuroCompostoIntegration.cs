using CalculoCobranca.CalculaJuro.Api.IntegrationTest.Provider;
using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace CalculoCobranca.CalculaJuro.Api.IntegrationTest.Controllers.v1
{
    public class JuroCompostoIntegration : ClientProvider
    {
        [Fact]
        public async Task Quando_executar_com_sucesso_Calculo_Juro_ReturnOK()
        {            
            var response = await TestClient.GetAsync(requestUri: "/api/v1/taxa/taxaJuros?valorInicial=100&meses=5");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
