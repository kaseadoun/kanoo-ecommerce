using Kanoo.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Adds IEmailSender interface to services and maps it to EmailSender
builder.Services.AddTransient<IEmailSender, EmailSender>(); 

// Add MySQL

var connectionString = builder.Configuration.GetConnectionString("Default") ?? throw new InvalidOperationException("Connection string not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>

   options.UseMySQL(connectionString));

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
    name: "Brief",
    pattern: "brief",
    defaults: new { controller = "Home", Action = "Brief" }
);
app.MapControllerRoute(
    name: "Privacy",
    pattern: "privacy",
    defaults: new { controller = "Home", Action = "Privacy" }
);

app.MapControllerRoute(
    name: "TravelServices",
    pattern: "travelservices",
    defaults: new { controller = "Home", Action = "TravelServices" }
);


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
