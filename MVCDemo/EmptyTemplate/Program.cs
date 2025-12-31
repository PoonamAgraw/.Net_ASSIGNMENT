namespace EmptyTemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "GET : Hello World!");
            //app.MapPost("/", () => "POST : Hello World!");
            //app.MapPut("/", () => "PUT : Hello World!");
            //app.MapDelete("/", () => "DELETE : Hello World!");


            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Helllo");
            //    await context.Response.WriteAsync("\nHii");
            //});
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("\nByee");

            //});
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello");
                await context.Response.WriteAsync("\nHi");
                next(context);
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello");
                next(context);
                await context.Response.WriteAsync("\nHi");
            });

            app.Run();
        }
    }
}
