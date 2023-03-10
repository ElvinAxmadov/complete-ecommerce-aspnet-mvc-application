using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace eTickets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options => 
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                              Initial Catalog=ecommerce-app-db;
                                              Integrated Security=True;
                                              Connect Timeout=30;
                                              Encrypt=False;
                                              TrustServerCertificate=False;
                                              ApplicationIntent=ReadWrite;
                                              MultiSubnetFailover=False"));

            builder.Services.AddScoped<IActorsService, ActorsService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            //app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            //Seed Data
            AppDbInitializer.Seed(app);
            app.Run();
        }
    }
}