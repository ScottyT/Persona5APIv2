using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persona5APIv2.Core.Data;
using Persona5APIv2.Core.Data.Entity;
using Persona5APIv2.Core.Logging;
using Persona5APIv2.Core.Service;
using Persona5APIv2.Infrastructure.Database;
using Persona5APIv2.Infrastructure.Database.Repository;
using Persona5APIv2.Infrastructure.Logging;
using AutoMapper;
using Persona5APIv2.Core.Service.Abstraction;

namespace Persona5APIv2
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
            //Database
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseInMemoryDatabase(databaseName: "PersonaDbV2");
            });
            //Repositories
            services.AddScoped<IGenericRepository<PersonaEntity>, GenericRepository<PersonaEntity>>();
            services.AddScoped<IGenericRepository<PersonaStatsEntity>, GenericRepository<PersonaStatsEntity>>();
            // Service
            services.AddScoped<IPersonaService, PersonaService>();
            services.AddScoped<IStatsService, StatsService>();
            services.AddAutoMapper();
            // Logging
            services.AddScoped(typeof(ILogger<>), typeof(NLogLogger<>));
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();
        }
    }
}
