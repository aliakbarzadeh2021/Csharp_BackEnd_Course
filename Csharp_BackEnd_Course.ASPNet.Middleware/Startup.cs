using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Example5._3._2.Middleware;

namespace Example5._3._2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //Middleware that catches exceptions and displays a generic error message
            app.UseMiddleware<CustomErrorHandlingMiddleware>();

            app.Use((context, next) =>
            {
                Random randomizer = new Random();
                int chance = randomizer.Next(10);
                if(chance % 2 == 0)
                {
                    throw new Exception("Invalid operation");
                }
                return next();
            });

            app.Map("/home", appBuilder =>
            {
                appBuilder.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Home Page");
                });
            });

            app.Map("/about", appBuilder =>
            {
                appBuilder.Run(async (context) =>
                {
                    await context.Response.WriteAsync("About Page");
                });
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello ASP.NET Core");
            });
        }
    }
}
