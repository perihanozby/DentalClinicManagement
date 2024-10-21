using Microsoft.EntityFrameworkCore;
using DentalClinicManagement.Data; // Eðer projenin adý DentalClinicManagement ise


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "doctors",
    pattern: "Doctors/{action=Index}/{id?}",
    defaults: new { controller = "Doctor" });

app.MapControllerRoute(
    name: "patients",
    pattern: "Patients/{action=Index}/{id?}",
    defaults: new { controller = "Patient" });

app.MapControllerRoute(
    name: "products",
    pattern: "Products/{action=Index}/{id?}",
    defaults: new { controller = "Product" });


app.MapControllerRoute(
    name: "admin",
    pattern: "Admin/{action=Login}/{id?}",
    defaults: new { controller = "Admin", action = "Login" });




app.Run();
