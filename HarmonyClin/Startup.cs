using AplicacationApp.Interfaces;
using AplicacationApp.OpenApp;
using Dominio.Interfaces.Generics;
using Dominio.Interfaces.InterfaceArtigo;
using Dominio.Interfaces.InterfaceImagens;
using Dominio.Interfaces.InterfaceRelatos;
using Dominio.Interfaces.InterfaceServices;
using Dominio.Services;
using Infraestrutura.Configuration;
using Infraestrutura.Repository.Generics;
using Infraestrutura.Repository.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HarmonyClin
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
            services.AddDbContext<ContextBase>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ContextBase>();
            services.AddControllersWithViews();

            //Generic
            services.AddScoped(typeof(IGeneric<>), typeof(RepositoryGenerics<>));

            //Imagem
            services.AddScoped<IImagem, RepositoryImagem>();
            services.AddScoped<IServiceImagem, ServiceImagem>();
            services.AddScoped<InterfaceImagem, AppImagem>();

            //relato
            services.AddScoped<IServiceRelato, ServiceRelato>();
            services.AddScoped<InterfaceRelato, AppRelato>();
            services.AddScoped<IRelato, RepositoryRelato>();

            //Aritgo
            services.AddScoped<IServiceArtigo, ServiceArtigo>();
            services.AddScoped<InterfaceArtigo, AppArtigo>();
            services.AddScoped<IArtigo, RepositoryArtigo>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
