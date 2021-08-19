using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace unleash_dotnet_sample
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                    webBuilder.ConfigureAppConfiguration(config =>
                    {
                        var connection = Environment.GetEnvironmentVariable("APP_CONFIG");
                        
                        config.AddAzureAppConfiguration(options =>
                            options.Connect(connection).UseFeatureFlags());
                    }).UseStartup<Startup>());
    }
}