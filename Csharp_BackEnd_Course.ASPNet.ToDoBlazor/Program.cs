using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace ToDoBlazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static WebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();
    }
}
