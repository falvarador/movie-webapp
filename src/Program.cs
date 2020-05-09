namespace WebApp
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Blazor.FileReader;
    using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using MovieWeb.WebApp.Common;
    using MovieWeb.WebApp.Services;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureServices(builder.Services);
            
            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IBaseService, BaseService>();
            services.AddScoped<IShowMessage, ShowMessage>();
            services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
        }
    }
}
