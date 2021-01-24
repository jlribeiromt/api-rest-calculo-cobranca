using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
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
