using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace HttpClientFactory
{

    class Program
    {
        static async Task<int> Main(string[] args)
        {
            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHttpClient();
                    services.AddTransient<IMyService, MyService>();
                }).UseConsoleLifetime();

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var myService = services.GetRequiredService<IMyService>();
                var pageContent = await myService.GetPage();
                Console.WriteLine(pageContent.Substring(0, 500));

            }

            return 0;
        }

        public interface IMyService
        {
            Task<string> GetPage();
        }

        public class MyService : IMyService
        {
            private readonly IHttpClientFactory _clientFactory;

            public MyService(IHttpClientFactory clientFactory)
            {
                _clientFactory = clientFactory;
            }

            public async Task<string> GetPage()
            {
                // Content from BBC One: Dr. Who website (©BBC)
                var request = new HttpRequestMessage(HttpMethod.Get,
                    "https://www.bbc.co.uk/programmes/b006q2x0");
                var client = _clientFactory.CreateClient();
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return $"StatusCode: {response.StatusCode}";
                }
            }
        }
    }

}
