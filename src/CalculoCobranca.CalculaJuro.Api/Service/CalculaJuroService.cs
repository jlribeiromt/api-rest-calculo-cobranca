using CalculoCobranca.CalculaJuro.Api.Core;
using CalculoCobranca.CalculaJuro.Api.Entites;
using CalculoCobranca.CalculaJuro.Api.Interface;

namespace CalculoCobranca.CalculaJuro.Api.Service
{
    public class CalculaJuroService : ICalculaJuroService
    {
        public ResultDTO ObterValorJuroComposto(double valorInicial, int meses)
        {
            var taxaJuro = 0.01D;
            var juro = new Juro(valorInicial, meses, taxaJuro);
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
