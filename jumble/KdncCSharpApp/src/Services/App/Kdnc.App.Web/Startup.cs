using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdnc.App.Web.Api;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Kdnc.Web
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
            services.AddMvc();
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = "Cookies";
                options.DefaultChallengeScheme = "oidc";
            })
            .AddCookie("Cookies")
            .AddOpenIdConnect("oidc", b =>
            {
                b.SignInScheme = "Cookies";
                b.Authority = "http://localhost:7000";
                b.RequireHttpsMetadata = false;

                b.ClientId = "kdncweb";
                b.ClientSecret = "secret";

                b.ResponseType = "code id_token";
                b.Scope.Add("kdncApi");
                b.SaveTokens = true;
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ValueApiService>();
            services.AddSingleton(x => new HttpClient { BaseAddress = new Uri("http://localhost:7002") });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory, HttpClient httpClient)
        {
            loggerFactory.AddConsole();

            app.UseAuthentication();
            app.UseDeveloperExceptionPage();

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Value}/{action=Index}/{id?}");
            });
        }
    }
}
