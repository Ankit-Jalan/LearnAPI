namespace LearnAPI
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Custom Middelware 1");

            await next(context);

            await context.Response.WriteAsync("Custom Middelware 2");
        }
    }
}
