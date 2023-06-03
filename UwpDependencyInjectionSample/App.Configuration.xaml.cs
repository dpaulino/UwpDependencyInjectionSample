using Microsoft.Extensions.DependencyInjection;
using System;

namespace UwpDependencyInjectionSample
{
    partial class App
    {
        private IServiceProvider _serviceProvider;

        public static IServiceProvider Services
        {
            get
            {
                IServiceProvider serviceProvider = ((App)Current)._serviceProvider 
                    ?? throw new InvalidOperationException("The service provider is not initialized");
                return serviceProvider;
            }
        }

        private static IServiceProvider ConfigureServices()
        {
            var provider = new ServiceCollection()
                .AddSingleton<IPrefixMaker, EnglishPrefixMaker>()
                //.AddSingleton<IPrefixMaker, FrenchPrefixMaker>()
                .AddSingleton<ClassWithDI>()
                .BuildServiceProvider(true);

            return provider;
        }
    }
}
