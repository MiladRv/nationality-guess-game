using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NationalityGuess.Domain.Model.Nationalitie;
using NationalityGuess.Domain.Model.PlayerGuesses;
using NationalityGuess.Domain.Model.Players;
using NationalityGuess.Infrastrucuture.Repository.Nationalities;
using NationalityGuess.Infrastrucuture.Repository.PlayerGeuesses;
using NationalityGuess.Infrastrucuture.Repository.Players;

namespace NationalityGuess
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
            // nationality services
            services.AddScoped<INationalityRepository, NationalityRepository>();

            // player services
            services.AddScoped<IPlayerRepository, PlayerRepository>();

            // playerGuess services
            services.AddScoped<IPlayerGuessRepository, PlayerGuessRepository>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
