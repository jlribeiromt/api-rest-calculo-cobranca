namespace CalculoCobranca.TaxaJuro.Api.Interface
{
    public interface ITaxaJuroService
    {
        /// <summary>
        /// Obter o valor da taxa de juros.
        /// </summary>
        /// <returns>Retorna o valor da taxa de juros.</returns>
        decimal ObterTaxaJuro();
    }
}
