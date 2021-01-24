using CalculoCobranca.TaxaJuro.Api.Interface;
using CalculoCobranca.TaxaJuro.Api.Service;
using Microsoft.Extensions.DependencyInjection;

namespace CalculoCobranca.TaxaJuro.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<ITaxaJuroService, TaxaJuroService>();
        }
    }
}
