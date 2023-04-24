using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlazorApp.Client;

namespace MyBlazorApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

#if MOCKNETAPI
            builder.Services.AddMockNetApi();
#else
            builder.Services.AddNetApi();
#endif

#if MOCKSERVICE
            builder.Services.AddMockAppServices();
#else
            builder.Services.AddAppServices();
#endif

            await builder.Build().RunAsync();
        }
    }
}