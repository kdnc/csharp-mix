using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdnc.App.Domain.DataAccess;
using Kdnc.App.Repository.DatabaseContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace Kdnc.App.API
{
    public class Startup
    {
//        public IConfiguration Configuration { get; }
      
//        public Startup(IHostingEnvironment env)
//        {
//            var builder = new ConfigurationBuilder()
//                .SetBasePath(env.ContentRootPath)
//                .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true)
//                .AddJsonFile($"appSettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
//                .AddEnvironmentVariables();
//
//            Configuration = builder.Build();
//        }

        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvcCore()
                .AddApiExplorer()
                .AddJsonFormatters();

            // register the DbContext on the container, getting the connection string from
            // appSettings (note: use this during development; in a production environment,
            // it's better to store the connection string in an environment variable)
//            var connectionString = Configuration["connectionStrings:libraryDBConnectionString"];
//            services.AddDbContext<ProductContext>
//                (cfg => cfg.UseSqlServer(Configuration.GetConnectionString("libraryDBConnectionString")));

            services.AddDbContext<SamuraiContext>(cfg =>
            {
                cfg.UseSqlServer(_config.GetConnectionString("SamuraiConnection"));
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Kdnc Ecommerce App", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, 
            ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Kdnc Ecommerce App V1");
            });

            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
            
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
            app.UseMvc();
        }
    }
}
