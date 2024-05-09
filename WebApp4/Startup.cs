﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WebApp4.Data.Interfaces;
using WebApp4.Data.Mocks;

namespace WebApp4
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllCars, MockCars>();
            services.AddTransient<ICarsCategory, MockCategory>();
            services.AddMvc();
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        public void Configure (IApplicationBuilder app, IHostEnvironment env)
        {
            
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
                app.UseStaticFiles();
                app.UseMvcWithDefaultRoute();
            

        }
    }
}

