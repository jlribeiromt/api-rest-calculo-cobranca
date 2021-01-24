using CalculoCobranca.CalculaJuro.Api.Core;

namespace CalculoCobranca.CalculaJuro.Api.Interface
{
    public interface ICalculaJuroService
    {
        ResultDTO ObterValorJuroComposto(double valorInicial, int meses);
    }
}
