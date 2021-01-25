using CalculoCobranca.CalculaJuro.Api.Core;
using CalculoCobranca.CalculaJuro.Api.Entites;
using CalculoCobranca.CalculaJuro.Api.Interface;
using System;

namespace CalculoCobranca.CalculaJuro.Api.Service
{
    public class CalculaJuroService : ICalculaJuroService
    {
        private readonly ITaxaJuroService _taxaJurotService;

        public CalculaJuroService(ITaxaJuroService taxaJurotService)
        {
            _taxaJurotService = taxaJurotService;
        }

        public ResultDTO ObterValorJuroComposto(double valorInicial, int meses)
        {
            var taxaJuroResult = _taxaJurotService.ObterTaxaJuro();
            var taxaJuro = !string.IsNullOrEmpty(taxaJuroResult) ? Convert.ToDecimal(taxaJuroResult) : 0;
            var juro = new Juro(valorInicial, meses, (double)taxaJuro);
            var resultDTO = new ResultDTO();

            // Validar a entidade
            if (!juro.IsValid())
            {
                resultDTO.Failure(juro.ValidationResult);
            }
            else
            {
                resultDTO.Success(juro.CalcularJuroComposto());
            }

            return resultDTO;
        }
    }
}
