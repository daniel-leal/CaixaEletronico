using System;
using System.Collections.Generic;
using System.Text;
using CaixaEletronico.Domain;
using Xunit;

namespace CaxaEletronico.UnitTests
{
    public class TheoriesTests
    {
        private readonly Caixa caixa = new Caixa();

        [Theory(DisplayName = "Saque contém menor número de cedulas")]
        [InlineData(3, 80)]
        [InlineData(3, 300)]
        [InlineData(5, 500)]
        public void SaqueContemMenorNumeroDeCedulas(int quantidadeDeCedulas, int valorDoSaque)
        {
            var resultadoCedulas = caixa.Saque(valorDoSaque);
            Assert.Equal(quantidadeDeCedulas, resultadoCedulas.Count);
        }
    }
}
