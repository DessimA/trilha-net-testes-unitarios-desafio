using System.Collections.Generic;
using Xunit;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests
{
    public class ValidacoesListaTests
    {
        private readonly ValidacoesLista _validacoes = new ValidacoesLista();

        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var resultadoEsperado = new List<int> { 5, 9 };

            // Act
            var resultado = _validacoes.RemoverNumerosNegativos(lista);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(new[] { 5, -1, -8, 9 }, 9, true)]
        [InlineData(new[] { 5, -1, -8, 9 }, 10, false)]
        public void DeveVerificarSeContemNumeroNaLista(IEnumerable<int> lista, int numero, bool resultadoEsperado)
        {
            // Convertendo IEnumerable<int> para List<int>
            var listaComoList = new List<int>(lista);

            // Act
            var resultado = _validacoes.ListaContemDeterminadoNumero(listaComoList, numero);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }


        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            // Arrange
            var lista = new List<int> { 5, 7, 8, 9 };
            var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

            // Act
            var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };

            // Act
            var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

            // Assert
            Assert.Equal(9, resultado);
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };

            // Act
            var resultado = _validacoes.RetornarMenorNumeroLista(lista);

            // Assert
            Assert.Equal(-8, resultado);
        }
    }
}
