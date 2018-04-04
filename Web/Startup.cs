using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Models;
using ReflectionIT.Mvc.Paging;
using Services.ControllerService;
using Services.ResourcesService;

namespace Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // Habilitando servicio para Paginación
            services.AddPaging();

            services.AddAntiforgery(o => o.HeaderName = "HSRF-TOKEN");
            // Obteniendo cadena de conexion y registrando DbContext sql-server
            var sqlConnection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ParroquiaDbContext>(options => options.UseSqlServer(sqlConnection));

            // Inyectando Dependencias de la capa de Servicios
            // Dependencia de listas necesarias para el formulario para crear bautismos
            services.AddTransient<ICreateBautismoService, CreateBautismoService>();
            // Dependencia crud de registros de Bautismo
            services.AddTransient<IBautismoService, BautismoService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {         

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();

                //app.Run(async (context) =>
                //{
                //    await context.Response.WriteAsync("Is Production");
                //});
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
