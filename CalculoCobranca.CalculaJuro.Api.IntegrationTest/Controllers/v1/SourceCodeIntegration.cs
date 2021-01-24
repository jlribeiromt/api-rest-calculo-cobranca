using CalculoCobranca.CalculaJuro.Api.IntegrationTest.Provider;
using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace CalculoCobranca.CalculaJuro.Api.IntegrationTest.Controllers.v1
{
    public class SourceCodeIntegration : ClientProvider
    {
        [Fact]
        public async Task Quando_obter_com_sucesso_Url_Projeto_ReturnOK()
        {
            var response = await TestClient.GetAsync("/api/v1/source/showmethecode");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
