using System;
using CaixaEletronico.Domain;
using Xunit;

namespace CaxaEletronico.UnitTests
{
    public class NormalAssertsTests
    {
        private readonly Caixa caixa = new Caixa();

        [Fact]
        public void Saque_Valido()
        {
            int valorDoSaque = 510;
            bool saqueEhValido = caixa.ValidaCedulasDisponiveis(valorDoSaque);

            Assert.True(saqueEhValido);
        }

        [Fact]
        public void Deve_Gerar_Excecao()
        {
            int valorDoSaque = 5;
            Assert.Throws<Exception>(() => caixa.Saque(valorDoSaque)); // Verifica se o método lança exceção
        }
    }
}
