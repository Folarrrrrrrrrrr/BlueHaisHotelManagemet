global using System;

global using Microsoft.AspNetCore.Mvc;
global using System.Diagnostics;
global using BlueHaisHotelManagemet.Models;
global using BlueHaisHotelManagemet.ViewModels;
global using Microsoft.EntityFrameworkCore;
global using BlueHaisHotelManagemet.Context;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvcCore();

var connectionString = builder.Configuration.GetConnectionString("BlueHaisConn") ?? throw new InvalidOperationException($"The connection string is not supported.");
builder.Services.AddDbContext<BlueHaisDbContext>(options => options.UseSqlServer(connectionString));
//builder.Services.AddDbContext<HotelDbContext>(options => options.UseSqlServer(
//    builder.Configuration.GetConnectionString("myconn"))
//    );

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
