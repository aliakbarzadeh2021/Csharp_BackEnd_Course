using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Example5._2._1.Services;
using System.Text;

namespace Example5._2._1
{
    public class Startup
    {
        //1. Constructor
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //4. Basic Configuration
        public IConfiguration Configuration { get; }
        
        //2. ConfigureServices
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<FooService>();
            services.AddMvc();
        }

        //3. Configure
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, FooService fooService)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                var names = fooService.GetNames();
                StringBuilder builder = new StringBuilder();
                foreach(var name in names)
                {
                    if(Configuration.GetValue<bool>("CapitalizedWords"))
                    {
                        builder.Append(name.ToUpper() + " ");
                    }
                    else
                    {
                        builder.Append(name + " ");
                    }
                }
                await context.Response.WriteAsync(builder.ToString());
            });

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}