namespace LearnAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Services           

            builder.Services.AddControllers();
            //builder.Services.AddTransient<CustomMiddleware>();

            #endregion

            #region Configure Service
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            #region Middelware Topic
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("I am an Use Middleware \n");
            //    await next();
            //    await context.Response.WriteAsync("I am an Use Middleware \n");
            //});

            //app.UseMiddleware<CustomMiddleware>();

            //app.Map("/ankit", con =>
            //{
            //    con.Use(async (context, next) =>
            //    {
            //        await context.Response.WriteAsync("experiment \n");
            //        await next(context);
            //    });
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("I am an Use Middleware two\n");
            //    await next();
            //});

            //app.Run(async context => await context.Response.WriteAsync("I am an Use Middleware"));

            #endregion

            app.UseRouting();
            //app.UseEndpoints(endpoints => endpoints.MapGet("/", async context => await context.Response.WriteAsync("Hello World")));
            app.UseEndpoints(endpoints => endpoints.MapControllers());
            app.Run();

            #endregion
        }

        public static void CustomCode(IApplicationBuilder app)
        {
            //app.Run(async cont => await cont.Response.WriteAsync("Let's test custom code \n"));           
        }
    }
}