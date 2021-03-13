using Ladybug.BesinessLogic;
using Ladybug.Data;
using Ladybug.Repository;
using Ladybug.Repository.NameBug;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Ladybug
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<LadybugContext>(option =>
            {
                option.UseNpgsql(Configuration.GetConnectionString("postgres"));
            });
            services.AddScoped<IHealthCheckRepository, HealthCheckRepository>();
            services.AddScoped<INameBugRepository, NameBugRepository>();
            services.AddScoped<ISeverityRepository, SeverityRepository>();
            services.AddScoped<IStatusRepository, StatusRepository>();
            services.AddScoped<NameBugBusinessLogic>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(options => options.SetIsOriginAllowed(x => _ = true).AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
