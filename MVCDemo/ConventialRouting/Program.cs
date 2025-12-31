namespace ConventialRouting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapDefaultControllerRoute();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Demo}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "bvs",
                pattern: "{controller=Admin}/{action=Index}/{name}");
            app.MapControllerRoute(
                name: "bvs",
                pattern: "{controller=Home}/action={UserCredential}/{unm}/{pwd}");
            app.Run();
        }
    }
}
