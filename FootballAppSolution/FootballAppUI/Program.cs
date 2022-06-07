using BusinessLogic;
using Common.Interfaces;
using Infastructure;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);
    config.AddJsonFile("protected.json",
        optional: true,
        reloadOnChange: true);
});





// Add services to the container.
builder.Services.AddControllersWithViews();
IServiceCollection services = builder.Services;
IConfiguration configuration = builder.Configuration;

string connectionString = configuration.GetConnectionString("DefaultConnection");
string connectionString1 = configuration["ConnectionStrings:DefaultConnection"];
services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
services.AddScoped<ITeamController, TeamController>();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();