using Microsoft.AspNetCore.Http;

namespace CUR2Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Configuration APP
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline. //day 3
            #region Custom Middleware

            //            app.Use(async (httpContext, next) =>
            //            {
            //               await httpContext.Response.WriteAsync("1-Middleware 1\n");
            //               await  next.Invoke();
            //                await httpContext.Response.WriteAsync("1-Middleware 1 1\n");


            //            });

            //            app.Use(async (httpContext, next) =>
            //            {
            //                await httpContext.Response.WriteAsync("2-Middleware 2\n");
            //                await next.Invoke();
            //                await httpContext.Response.WriteAsync("2-Middleware 2 2\n");


            //            });

            //            app.Run(async(httpContext) =>
            //            {
            //                await httpContext.Response.WriteAsync("Terminate \n");
            //            });
            //;








            #endregion



            #region Built in Middleware
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            //Deprtment/New
            //Department/Details/1
            app.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=Department}/{action=Index}/{id?}");

            //app.MapControllerRoute(
            //    name:"MyRoute",
            //    pattern:"emp/{controller}/{action}",
            //    defaults: new {controller="Employee",action="index"}
            //    );

            #endregion


            app.Run();//Run Application
        }
    }
}