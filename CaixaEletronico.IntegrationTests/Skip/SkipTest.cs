using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CaixaEletronico.Api;
using CaixaEletronico.IntegrationTests.Config;
using Xunit;

namespace CaixaEletronico.IntegrationTests
{
    public class SkipTest
    {
        private readonly IntegrationTestFixture<StartupApiTests> _integrationTestFixture;

        public SkipTest(IntegrationTestFixture<StartupApiTests> integrationTestFixture)
        {
            _integrationTestFixture = integrationTestFixture;

        }

        [Fact(DisplayName = "Saque com sucesso", Skip = "Teste defasado, não mais necessário")]
        public async Task Saque_com_sucesso()
        {
            var requisicao = await _integrationTestFixture.Client.PostAsJsonAsync($"/api/CaixaEletronico/saque/100", new { });

            Assert.True(requisicao.IsSuccessStatusCode);
        }
    }
}
