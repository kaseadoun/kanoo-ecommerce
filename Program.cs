using Kanoo.Data;
using Kanoo.Models;
using Kanoo.Services;
using Microsoft.AspNetCore.Identity;
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

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Adding identity service and roles
builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Program.cs
// Registering the DbInitializer seeder
builder.Services.AddTransient<DbInitializer>();

// Inject CartService in our application
builder.Services.AddScoped<CartService>();

// Takes our appsettings file and injects it into all of our files, so long as it is instantiated in the constructor
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

var app = builder.Build();

app.UseSession();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Seed roles
var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using var scope = scopeFactory.CreateScope();
var initializer = scope.ServiceProvider.GetRequiredService<DbInitializer>();
await DbInitializer.Initialize(
    scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>(),
    scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>()
);

app.UseHttpsRedirection();
app.UseStaticFiles();

// Setup authentication and authorization
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();

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
    name: "View My Cart",
    pattern: "Carts",
    defaults: new { controller = "Home", Action = "Carts" }
);


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
