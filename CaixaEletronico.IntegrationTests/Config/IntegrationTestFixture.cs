using System;
using System.Net.Http;
using CaixaEletronico.Api;
using Xunit;

namespace CaixaEletronico.IntegrationTests.Config
{
    [CollectionDefinition(nameof(IntegrationApiTestFixtureCollection))]
    public class IntegrationApiTestFixtureCollection : ICollectionFixture<IntegrationTestFixture<StartupApiTests>>
    {

    }
    public class IntegrationTestFixture<TStartup> : IDisposable where TStartup : class
    {
        public readonly CaixaEletronicoAppFactory<TStartup> Factory;
        public HttpClient Client;

        public IntegrationTestFixture()
        {
            var clientOptions = new Microsoft.AspNetCore.Mvc.Testing.WebApplicationFactoryClientOptions()
            {
                HandleCookies = false,
                BaseAddress = new Uri("https://localhost:5001"),
                AllowAutoRedirect = true,
                MaxAutomaticRedirections = 7
            };

            Factory = new CaixaEletronicoAppFactory<TStartup>();
            Client = Factory.CreateClient(clientOptions);
        }
        public void Dispose()
        {
            Client.Dispose();
            Factory.Dispose();
        }
    }
}
