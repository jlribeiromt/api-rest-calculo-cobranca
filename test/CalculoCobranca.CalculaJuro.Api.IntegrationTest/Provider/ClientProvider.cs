using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;

namespace CalculoCobranca.CalculaJuro.Api.IntegrationTest.Provider
{
    public class ClientProvider
    {
        protected readonly HttpClient TestClient;

        public ClientProvider()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            TestClient = appFactory.CreateClient();
        }      
    }
}
