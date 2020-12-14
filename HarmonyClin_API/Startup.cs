using AplicacationApp.Interfaces;
using AplicacationApp.OpenApp;
using Dominio.Interfaces.Generics;
using Dominio.Interfaces.InterfaceArtigo;
using Dominio.Interfaces.InterfaceImagens;
using Dominio.Interfaces.InterfaceRelatos;
using Dominio.Interfaces.InterfaceServices;
using Dominio.Interfaces.InterfaceUsuario;
using Dominio.Services;
using Infraestrutura.Configuration;
using Infraestrutura.Repository.Generics;
using Infraestrutura.Repository.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Text;

namespace HarmonyClin_API
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HarmonyClin_API", Version = "v1" });
            });

            services.AddDbContext<ContextBase>(options =>
    options.UseSqlServer(
        Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllersWithViews();

            services.AddCors();

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

            //Usuario
            services.AddScoped<IServiceUsuario, ServiceUsuario>();
            services.AddScoped<InterfaceUsuario, AppUsuario>();
            services.AddScoped<IUsuario, RepositoryUsuario>();

            string secret = Environment.GetEnvironmentVariable("ClientSecret");
            var key = Encoding.ASCII.GetBytes(secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(y =>
            {
                y.RequireHttpsMetadata = false;
                y.SaveToken = true;
                y.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HarmonyClin_API v1"));
            }

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
