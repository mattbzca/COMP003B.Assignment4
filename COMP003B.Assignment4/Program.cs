/*
 * Author: Matthew Tan 
 * Course Name: COMP-003B ASP.NET Core
 * Faculty Name: Jonathan Cruz
 * Purpose: This is my ASP.NET Core Mini-Project demonstrating all MVC concepts from Modules 1 to 4.
 */

using COMP003B.Assignment4.Middleware;

namespace COMP003B.Assignment4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseMiddleware<COMP003B.Assignment4.Middleware.RequestLoggingMiddleware>();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
