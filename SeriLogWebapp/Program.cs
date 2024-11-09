using Microsoft.AspNetCore.Hosting;
using Serilog;
using SeriLogExceptionHandlingLib;
using SeriLogWebapp;



public class Program
{
    private static void Main(string[] args)
    {
        //var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        Log.Logger = new LoggerConfiguration()
.WriteTo.Console()
.CreateLogger();
        try
        {
            Log.Information("Starting web host");
            CreateHostBuilder(args).Build().Run();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Host terminated unexpectedly");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    

  
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>Host.CreateDefaultBuilder(args)
.UseSerilog() // Enable Serilog for logging
.ConfigureWebHostDefaults(webBuilder =>
{
    webBuilder.UseStartup<Startup>();
});
}


