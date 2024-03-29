using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PurchasingV1Web.Models;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        // Veritabanı bağlantı string'ini appsettings.json dosyasından okuyun
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddDbContext<PurchasingV1WebContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error"); // Hata işleyicisini kullanın
        }

        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}