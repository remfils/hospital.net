using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Hospital.WEB
{

    /// <summary>
    /// Для локальных настроек можно использовать appsettings.local.json
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable("BASEDIR", AppContext.BaseDirectory);


            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            Log.Information("Started app");

            try
            {
                CreateHostBuilder(args).Build().Run();
                Log.Information("Created host builder successfully");
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application start-up failed");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {

                    webBuilder
                        .UseStartup<Startup>()
                        .ConfigureAppConfiguration(config =>
                        {
                            config
                                .AddJsonFile("appsettings.local.json", optional: true);
                        })
                        .UseSerilog((hostingContext, loggerConfiguration) =>
                        {
                            loggerConfiguration
                                .ReadFrom.Configuration(hostingContext.Configuration)
                                .Enrich.FromLogContext();
                        });
                });
    }
}
