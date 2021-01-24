using CalculoCobranca.CalculaJuro.Api.Core;
using CalculoCobranca.CalculaJuro.Api.Interface;
using Moq;
using Xunit;

namespace CalculoCobranca.CalculaJuro.Api.Test.Service
{
    public class CalculaJuroServiceTest
    {
        

        [Theory]
        [InlineData(100, 5)]
        [InlineData(0, 2)]
        public void Quando_informar_ValorInicial_igual_a_zero_nao_deve_calcular(double valorInicial, int meses)
        {
            // arrange                        
            Mock<ICalculaJuroService> _service = new Mock<ICalculaJuroService>();
            ResultDTO resulDTO = new ResultDTO();
            // act
            var result = _service.Object.ObterValorJuroComposto(valorInicial, meses);
            _service.Setup(c => c.ObterValorJuroComposto(It.IsAny<double>(), It.IsAny<int>())).Returns(resulDTO);

            var dto = _service.Object.ObterValorJuroComposto(valorInicial, meses);

            // assert
            Assert.False(dto.OperationSuccess);
        }

        [Theory]
        [InlineData(-100, -5)]
        [InlineData(-200, -10)]
        [InlineData(0, 0)]
        public void Quando_informar_ValorInicial_Meses_invalidos_nao_deve_calcular(double valorInicial, int meses)
        {
            // arrange                        
            Mock<ICalculaJuroService> _service = new Mock<ICalculaJuroService>();
            ResultDTO resulDTO = new ResultDTO();
            // act
            var result = _service.Object.ObterValorJuroComposto(valorInicial, meses);
            _service.Setup(c => c.ObterValorJuroComposto(It.IsAny<double>(), It.IsAny<int>())).Returns(resulDTO);

            var dto = _service.Object.ObterValorJuroComposto(valorInicial, meses);

            // assert
            Assert.False(dto.OperationSuccess);
        }
    }
}
