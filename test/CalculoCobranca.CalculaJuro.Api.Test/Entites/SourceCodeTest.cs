using CalculoCobranca.CalculaJuro.Api.Entites;
using System;
using Xunit;

namespace CalculoCobranca.CalculaJuro.Api.Test.Entites
{
    public class SourceCodeTest
    {
        [Fact]
        public void Quando_criar_com_Url_valida()
        {
            // arrange
            var url = SourceCode.Url;

            // act
            var resultCreate = Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out _);

            // assert
            Assert.True(resultCreate);
        }

        [Theory]
        [InlineData("")]        
        [InlineData(null)]
        public void Quando_criar_com_Url_invalida(string url)
        {
            // act
            var resultCreate = string.IsNullOrWhiteSpace(url);

            // assert
            Assert.True(resultCreate);

        }        
    }
}
