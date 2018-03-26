﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stn.Homa.Ef;
using Stn.Homa.Fleet.Api.Services;
using Stn.Homa.Fleet.Services.CarModels;
using Stn.Homa.Fleet.Services.Cars;
using Stn.Homa.Fleet.Services.Temp;

namespace Stn.Homa.WebApi
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
            services.AddDbContext<HomaDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("HomaDatabase")));

            services.AddMvc();

            services.AddTransient<IValuesService, ValuesService>();
            services.AddTransient<ICarModelsService, CarModelsService>();
            services.AddTransient<ICarsService, CarsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
