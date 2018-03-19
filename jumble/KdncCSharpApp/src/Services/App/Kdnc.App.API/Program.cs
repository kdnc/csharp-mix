using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Kdnc.App.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "API";
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://localhost:7002")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
