using Data_Layer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Repository_Layer.Interfaces;
using Repository_Layer.Logics;
using ServiceLayer.Interfaces;
using ServiceLayer.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FInalDemoProject_ProjectSession
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

            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
                options.JsonSerializerOptions.DictionaryKeyPolicy = null;
            });
            services.AddControllers();
            services.AddControllersWithViews();
            services.AddDbContext<SessionDbContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("ConnStr")));
            services.AddSwaggerGen();
            services.AddScoped<IAdminRegistrationServices, AdminRegistrationServices>();
            services.AddScoped<IAdminRegistrationRepo, AdminRegistrationRepo>();
            services.AddScoped<ICreateNewSessionRepo, CreateNewSessionRepo>();
            services.AddScoped<ICreateNewSessionServices, CreateNewSessionServices>();
            services.AddScoped<ISessionLogsRepo, SessionLogsRepo>();
            services.AddScoped<ISessionLogsServices, SessionLogsServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Session API V1");

                // To serve SwaggerUI at application's root page, set the RoutePrefix property to an empty string.
                //c.RoutePrefix = "";
            });

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
