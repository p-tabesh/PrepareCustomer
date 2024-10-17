using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using AspNETProj.DatabaseContext;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>(
    option =>
    {
        option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    });



// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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