using E_Shop.Data;
using E_Shop.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(op =>
   op.UseSqlServer(builder.Configuration.GetConnectionString("AppDbContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<ProductService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();