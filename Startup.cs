using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fluid;
using Fluid.MvcViewEngine;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleWebLiquid.Models;

namespace SimpleWebLiquid
{
    public class Startup
    {
        static Startup() => TemplateContext.GlobalMemberAccessStrategy.Register<Pessoa>();
        public void ConfigureServices(IServiceCollection services) => services.AddMvc().AddFluid();

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Pessoa}/{action=Index}/{id?}");
            });
        }
    }
}
