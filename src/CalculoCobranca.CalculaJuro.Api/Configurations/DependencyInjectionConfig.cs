using CalculoCobranca.CalculaJuro.Api.Interface;
using CalculoCobranca.CalculaJuro.Api.Service;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace CalculoCobranca.CalculaJuro.Api.Configurations
{
    /// <summary>
    /// Extensão para o registro das interfaces/implementações.
    /// </summary>
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<ICalculaJuroService, CalculaJuroService>();
            services.AddScoped<ITaxaJuroService, TaxaJuroService>();
        }
    }
}
