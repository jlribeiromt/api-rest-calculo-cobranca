using CalculoCobranca.TaxaJuro.Api.Interface;

namespace CalculoCobranca.TaxaJuro.Api.Service
{
    public class TaxaJuroService : ITaxaJuroService
    {
        /// <summary>
        /// Obter o valor da taxa de juros.
        /// </summary>
        /// <returns>Retorna o valor da taxa de juros.</returns>
        public double ObterTaxaJuro()
        {
            return 0.01D;
        }
    }
}
