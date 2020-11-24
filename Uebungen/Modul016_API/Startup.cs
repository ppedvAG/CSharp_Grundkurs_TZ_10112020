using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Modul016_API.Data;

namespace Modul016_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // der ConfigureService wird zur Laufzeit aufgerufen
        // hier muessen alle Services hinzugefuegt werden
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // ueber den DbContext wird die Verbindung zur Datenbank hergestellt
            // der ConnectionString wird in der appsettings.json Datei verwaltet
            services.AddDbContext<TodoContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("TodoContext")));
        }

        // die Configure Methode wird zur Laufzeit aufgerufen
        // hier werden die grudlegenden Bedingungen im Bezug auf HTTP festgelegt
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // spezielle Fehlerseite in der Entwicklungsumgebung
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // automatische Umleitung auf HTTPS
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
