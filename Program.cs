using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Data; // Added namespace for EmployeeContext

var builder = WebApplication.CreateBuilder(args);

// Ensure appsettings.json is loaded
builder.Configuration.AddJsonFile("appsettings.json", optional: false);

// Configure services
builder.Services.AddControllersWithViews();

// Add EmployeeContext with configuration from appsettings.json
builder.Services.AddDbContext<EmployeeContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("EmployeeContext"));

});

// Build the application
var app = builder.Build();

// Configure the HTTP request pipeline
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
