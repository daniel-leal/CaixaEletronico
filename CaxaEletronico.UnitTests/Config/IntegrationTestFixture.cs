using System;
using System.Collections.Generic;
using System.Text;
using CaixaEletronico.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace CaxaEletronico.UnitTests.Config
{
    public class IntegrationTestFixture
    {
        public IntegrationTestFixture()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<ICaixa, Caixa>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        public ServiceProvider ServiceProvider { get; set; }
    }
}
