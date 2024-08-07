using BUILDPROJECTSHERRY.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BulidProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Data Source =DESKTOP-OGKSQ2L\\SHERRY ; Initial Catalog = BULID_PROJECT; Integrated Security = True; Encrypt = True; TrustServerCertificate = True")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
