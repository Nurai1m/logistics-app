using Serilog;
using System.Net;

namespace Web
{
    public class Program
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
            .Build();

        public static void Main(string[] args)
        {
            //Log.Logger = new Serilog.LoggerConfiguration()
            //    .ReadFrom.Configuration(Configuration)
            //    .Enrich.FromLogContext()
            //    .CreateLogger();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureKestrel(serverOptions =>
                    {
                        serverOptions.Listen(IPAddress.Loopback, 6000);
                        serverOptions.Limits.MaxRequestBodySize = 10485760;
                    })
                    .UseStartup<Startup>();
                });
    }
}