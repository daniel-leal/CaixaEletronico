using System;
using System.Collections.Generic;
using System.Text;
using CaixaEletronico.Domain;
using CaxaEletronico.UnitTests.Config;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace CaxaEletronico.UnitTests
{
    public class FixtureTests : IClassFixture<IntegrationTestFixture>
    {
        private ICaixa _caixa;

        public FixtureTests(IntegrationTestFixture fixture)
        {
            _caixa = fixture.ServiceProvider.GetRequiredService<ICaixa>();
        }

        [Fact]
        public void SaqueContemMenorNumeroDeCedulas()
        {
            int quantidadeDeCedulas = 3;
            int valorDoSaque = 80;

            var resultadoCedulas = _caixa.Saque(valorDoSaque);

            Assert.Equal(quantidadeDeCedulas, resultadoCedulas.Count);
        }
    }
}
