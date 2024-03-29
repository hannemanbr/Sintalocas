﻿using System;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MobileApp.Application.Interfaces;
using MobileApp.Application.Service;
using MobileApp.DAL.EF;
using MobileApp.DAL.EF.Repositories;
using MobileApp.Infra.Common.Repository;

namespace MobileApp.Web.Api
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Contexto

            services.AddScoped<ContextDB, ContextDB>();
            services.AddScoped<INoticiaRepository, NoticiaRepository>();
            services.AddScoped<INoticiaService, NoticiaService>();
            services.AddDbContext<ContextDB>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionString"],
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(
                        typeof(Startup).GetTypeInfo().Assembly.GetName().Name);

            //Configuring Connection Resiliency:
            sqlOptions.
                EnableRetryOnFailure(maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null);

                });

                // Changing default behavior when client evaluation occurs to throw.
                // Default in EFCore would be to log warning when client evaluation is done.
                options.ConfigureWarnings(warnings => warnings.Throw(
                    RelationalEventId.QueryClientEvaluationWarning));
            });

            //...
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
