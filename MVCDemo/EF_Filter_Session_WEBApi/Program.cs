using _EF_Filter_Session_WEBApi.Filters;
using _EF_Filter_Session_WEBApi.Models;
using Microsoft.EntityFrameworkCore;

namespace _EF_Filter_Session_WEBApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<DACContext>(options => {
                options.UseSqlServer("name=DAC");
            });

            builder.Services.AddCors(corsoptions => {
                corsoptions.AddPolicy("IET", (corspolicy) => {
                    corspolicy.WithOrigins("*").WithMethods("*").WithHeaders("*");
                });
            });
            builder.Services.AddExceptionHandler<IETExExceptionFilter>();

            builder.Services.AddSession();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors();

            app.UseSession();

            app.UseExceptionHandler("/Exception/Error");

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
