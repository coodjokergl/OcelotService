using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace OcelotService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                //.ConfigureAppConfiguration((hostingContext, config) =>
                //{
                //    config
                //        .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                //        .AddJsonFile("appsettings.json", true, true)
                //        .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true, true)
                //        .AddJsonFile("ocelot.json")
                //        .AddEnvironmentVariables();
                //})
                //.ConfigureServices(s => {
                //    s.AddOcelot();
                //})
                //.ConfigureLogging((hostingContext, logging) =>
                //{
                //    //add your logging
                //})
                //.UseIISIntegration()
                //.Configure(app =>
                //{
                //    app.UseOcelot().Wait();
                //})
                .Build()
                .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            new WebHostBuilder()
                .ConfigureServices(s => {
                })
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>();
    }
}
