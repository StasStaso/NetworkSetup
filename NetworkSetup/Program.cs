using Microsoft.Extensions.DependencyInjection;
using NetworkSetup.Model;
using NetworkSetup.Service;
using System;

namespace NetworkSetup
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<Form1>();
            services.AddTransient<InputVlan>();
            services.AddSingleton<SwitchConfigurationDcn>();
            services.AddTransient<Logger>();
        }
    }
}