using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Kdnc.App.API
{
    /*
    Kdnc Step

    Reference - https://docs.microsoft.com/en-us/aspnet/core/security/enforcing-ssl?view=aspnetcore-2.1&tabs=visual-studio

    When a browser that supports HSTS receives this header:
    - The browser stores configuration for the domain that prevents sending any communication over HTTP.
    The browser forces all communication over HTTPS.
    - The browser prevents the user from using untrusted or invalid certificates.The browser disables prompts 
    that allow a user to temporarily trust such a certificate.
    
    Because HSTS is enforced by the client it has some limitations:

    - The client must support HSTS.
    - HSTS requires at least one successful HTTPS request to establish the HSTS policy.
    - The application must check every HTTP request and redirect or reject the HTTP request.
    */
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            /*
             Kdnc Step 2

             - Sets the preload parameter of the Strict-Transport-Security header. 
             Preload isn't part of the RFC HSTS specification, but is supported by web browsers to 
             preload HSTS sites on fresh install. See https://hstspreload.org/ for more information.
             - Enables includeSubDomain, which applies the HSTS policy to Host subdomains.
             - Explicitly sets the max-age parameter of the Strict-Transport-Security header to 60 days. 
             If not set, defaults to 30 days. See the max-age directive for more information.
             - Adds example.com to the list of hosts to exclude.
             */
            services.AddHsts(options =>
            {
                options.Preload = true;
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromDays(60);
                options.ExcludedHosts.Add("example.com");
                options.ExcludedHosts.Add("www.example.com");
            });
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
                /*
                 Kdnc Step 1

                 UseHsts isn't recommended in development because the HSTS settings are highly 
                 cacheable by browsers. 
                 By default, UseHsts excludes the following loopback hosts
                    localhost : The IPv4 loopback address.
                    127.0.0.1 : The IPv4 loopback address.
                    [::1] : The IPv6 loopback address.
                 */
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
