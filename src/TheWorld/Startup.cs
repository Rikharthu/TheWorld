using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace TheWorld
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // register all our mvc services
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {

            // Configure the middleware here
            // define who is handling what and in what order

            loggerFactory.AddConsole();

#if DEBUG
            // Do this code only if we are on a development machine
            // if exception/error occurs on the server, then return webpage with detailed information
            app.UseDeveloperExceptionPage();
#endif
            // we could also use this
            if (env.IsEnvironment("Development"))
            {
                //app.UseDeveloperExceptionPage();
                /* it check ASPNETCORE_ENVIRONMENT environment variable
                 which is defined in application propertis
                 TheWorls ->alt+enter->Debug->Environment variables */
            }
            // or such
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
            }
            



            //// Configure what source of code will handle the requests when the come in
            //app.Run(async (context) =>
            //{
            //    // configure what happens on requests
            //    // this is very low-level configuration
            //    await context.Response.WriteAsync("<html><body><h3>Hello World!</h3></body></html>");
            //});

            // 1. add standart default files (i.e. automatically look for index.html and etc)
            /* without that we would have to type http://localhost:52143/index.html instead of just http://localhost:52143 */
            // we let MVC6 do the shit
            //app.UseDefaultFiles();
            // 2. include middleware that is required to serve files to the browser (displaying our .html files)
            app.UseStaticFiles();
            // middleware initialization order matters!

            // Configure MVC6
            app.UseMvc(config =>
            {
                // use struct to route controller
                config.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new
                    {
                        controller="App",
                        action="index"
                        
                    }
                );
            });
        }
    }
}
