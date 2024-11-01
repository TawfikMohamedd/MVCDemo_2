namespace MVCDemo_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseRouting();

            app.UseStaticFiles();

            #region MyRegion
            ////app.UseEndpoints(endpoints =>
            ////    {
            ////        endpoints.MapGet("/Home", async context =>
            ////        {
            ////            await context.Response.WriteAsync("this is the home Page");
            ////        });

            ////        endpoints.MapGet("/Products", async context =>
            ////        {
            ////            await context.Response.WriteAsync("Prooooooooooooooducts");
            ////        });

            ////        endpoints.MapGet("/Books/ {ID} / {Auther}", async context =>
            ////        {
            ////            int id = Convert.ToInt32(context.Request.RouteValues["ID"]);
            ////            string name = context.Request.RouteValues["Auther"].ToString();
            ////            await context.Response.WriteAsync($"You Are at Booksss id=> {id}, At Author =>{name}");
            ////        });

            ////    }); 
            #endregion

        //app.MapControllerRoute(
        //    name: "default",
        //    pattern: "{Controller=Home}/{Action=Index}",
        //    defaults: new { Controller = "Home", Action = "Index" });

            app.MapControllerRoute(
            name: "default",
            pattern: "{Controller=Home}/{Action=Privacy}",
            defaults: new { Controller = "Home", Action = "Privacy" });

            //app.Run(async (HttpContext) => { await HttpContext.Response.WriteAsync("Your Request Page Is not Found"); });
            //app.MapGet("/Home", () => "Hello World!");

            app.Run();
        }
    }
}
