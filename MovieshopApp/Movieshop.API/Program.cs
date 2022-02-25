using Movieshop.API;

CreateHostBuilder().Build().Run();

 static IHostBuilder CreateHostBuilder()
{
    return Host.CreateDefaultBuilder().ConfigureWebHostDefaults(webHost =>
    {
        webHost.UseStartup<Startup>();
    });
}