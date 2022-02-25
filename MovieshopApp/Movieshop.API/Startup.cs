namespace Movieshop.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection service)
        { 
            service.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region Middleware Practice
            //app.Use(async (context, next) => 
            //{
            //    await context.Response.WriteAsync("Middleware 1 - Request.\n");
            //    next();
            //    await context.Response.WriteAsync("Middleware 1 - Response.\n");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Middleware 2 - Request.\n");
            //    next();
            //    await context.Response.WriteAsync("Middleware 2 - Response.\n");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Middleware 3 - Request.\n");
            //});
            #endregion

            if (env.IsDevelopment()) { 
            app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                #region Root URL and URL 
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Welcome to dot net core.");
                //});
                //endpoints.MapGet("/antra", async context =>
                //{
                //    await context.Response.WriteAsync("Welcome to Antra.");
                //});
                #endregion
                endpoints.MapControllers();
            });

        }
    }
}
