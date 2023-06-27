using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using ClientesApp.Models;

namespace ClientesApp
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configurar Entity Framework Core con SQL Server
            services.AddDbContext<ClientesBDContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Otros servicios y configuraciones necesarios
            // ...

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // Configuraciones de producción
                // ...
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
