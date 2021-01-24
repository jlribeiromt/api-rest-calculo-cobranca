using CalculoCobranca.CalculaJuro.Api.Entites;
using Xunit;

namespace CalculoCobranca.CalculaJuro.Api.Test.Entites
{
    public class JuroTest
    {
        [Theory]        
        [InlineData(0, 5)]
        [InlineData(0, 2)]
        public void Quando_informar_ValorInicial_igual_a_zero_deve_retornar_zero(double valorInicial, int meses)
        {
            // arrange
            double taxaJuro = 0.01;
            var juro = new Juro(valorInicial, meses, taxaJuro);

            // act
            var valorCalculo = juro.CalcularJuroComposto();

            // assert
            Assert.Equal(0, valorCalculo);
        }

        [Theory]
        [InlineData(-100, -5)]
        [InlineData(-200, -10)]
        [InlineData(0, 0)]
        public void Quando_informar_ValorInicial_Meses_Invalidos(double valorInicial, int meses) 
        {
            // arrange
            double taxaJuro = 0.01;
            var juro = new Juro(valorInicial, meses, taxaJuro);

            // act
            var isValid = juro.IsValid();

            // assert
            Assert.False(isValid);
        }
    }
}
