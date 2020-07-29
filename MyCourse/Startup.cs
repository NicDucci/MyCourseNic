using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MyCourse
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // MIDDLEWARE che produce una pagina informativa in caso si verificasse un errore nell'applicazione
            }
            app.UseStaticFiles();

            

            app.UseMvc(routeBuilder => 
            {
                routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
                /*
                 * Home e Index sono rispettivamente il controllet e l'action di default
                 * quindi non è più necessario passarli tramite url, l'id invece è diventato
                 * opzionale con l'aggiunta del '?'.
                 * Questa Route è definita route di default e può essere usata richiamando
                 * il metodo app.UseMvcWithDefaultRoute();
                */
            });
        }
    }
}
