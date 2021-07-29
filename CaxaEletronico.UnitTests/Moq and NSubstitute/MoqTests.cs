using System;
using System.Collections.Generic;
using System.Text;
using CaixaEletronico.Domain;
using Moq;
using NSubstitute;
using Xunit;

namespace CaxaEletronico.UnitTests
{
    public class MoqTests
    {
        [Fact]
        public void Saque_Com_Sucesso_NSub()
        {
            var caixa = Substitute.For<ICaixa>(); // Cria objeto mock
            int valorDoSaque = 50;

            caixa.Saque(valorDoSaque).Returns(new int[] { }); // efetua simulação de saque e assegura que o retorn é array de int
            caixa.Received(1); // confirma que método foi executado uma unica vez.                                                         
        }

        [Fact]
        public void Saque_Com_Sucesso_Moq()
        {
            var caixa = new Mock<ICaixa>(); // Cria objeto mock
            int valorDoSaque = 50;

            caixa.Object.Saque(valorDoSaque);
            caixa.Verify(r => r.Saque(valorDoSaque), Times.Once);
        }
    }
}
