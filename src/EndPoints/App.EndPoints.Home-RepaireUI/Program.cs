    
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using App.Domain.AppService.Admins;
using App.Domain.Core.AppServices.Admins;
using App.Infrastructures.Data.Repositories.DataAccess.Repositories;
using App.Infrastructures.Data.Repositories.AutoMapper;
using App.Infrastructures.Db.SqlServer.Ef;
using App.Domain.Core.DataAccess;
using System.Reflection;
using AutoMapper;
using App.Infrastructures.Db.SqlServer.Ef.Database;
using System.Configuration;
using System;
using Microsoft.Extensions.DependencyInjection;
using App.Domain.Core.Entities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

// Add services to the container.

builder.Services.AddDbContext<MarketDbContext>(option =>
{
    option.UseSqlServer("Server=.;Initial Catalog=MarketDb;Integrated Security=True ;TrustServerCertificate=True");
});


builder.Services.AddIdentity<AppUser,IdentityRole<int>>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<MarketDbContext>();


builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(AutoMapping)));


builder.Services.AddScoped<ICommentRipository, CommentRipository>();
builder.Services.AddScoped<ICommentAppservice, CommentAppservice>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseMigrationsEndPoint();
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//else
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "areas",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
