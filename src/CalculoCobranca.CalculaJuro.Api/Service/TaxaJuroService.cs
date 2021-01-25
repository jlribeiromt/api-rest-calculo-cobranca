using CalculoCobranca.CalculaJuro.Api.Interface;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
namespace CalculoCobranca.CalculaJuro.Api.Service
{
    public class TaxaJuroService : ITaxaJuroService
    {
        private string _baseUri = System.Diagnostics.Debugger.IsAttached
                                   ? "https://localhost:64970"
                                   : "http://localhost:64978";

        private readonly IHttpClientFactory _clientFactory;

        public TaxaJuroService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public string ObterTaxaJuro()
        {
            try
            {
                var client = _clientFactory.CreateClient();
                client.BaseAddress = new Uri(_baseUri);
                string retorno = string.Empty;

                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                var request = new HttpRequestMessage(HttpMethod.Get, "api/v1/taxa/taxaJuros");

                var response = client.SendAsync(request).Result;

                if (response.IsSuccessStatusCode)
                    retorno = response.Content.ReadAsStringAsync().Result;

                return retorno.Replace('.', ',');
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
