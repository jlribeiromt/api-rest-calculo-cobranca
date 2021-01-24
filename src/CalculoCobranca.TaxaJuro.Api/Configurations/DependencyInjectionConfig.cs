using CalculoCobranca.TaxaJuro.Api.Interface;
using CalculoCobranca.TaxaJuro.Api.Service;
using Microsoft.Extensions.DependencyInjection;

namespace CalculoCobranca.TaxaJuro.Api.Configurations
{
    /// <summary>
    /// Extensão para o registro das interfaces/implementações.
    /// </summary>
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<ITaxaJuroService, TaxaJuroService>();
        }
    }
}
