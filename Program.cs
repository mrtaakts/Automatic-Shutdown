using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Automatic_Shutdown;
using SharedLibrary.Services;

namespace Automatic_Shutdown
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<ITimerService, TimerService>();
                    services.AddTransient<IConfig, Config>();
                    services.AddTransient<Form1>();
                });
        }
    }
}