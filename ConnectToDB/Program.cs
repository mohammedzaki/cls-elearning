using ConnectToDB.Data;
using ConnectToDB.Data.Repos;
using ConnectToDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var _connType = builder.Configuration.GetValue<string>("DatabaseEngine");
var _connectionString = "";

builder.Services.AddDbContext<ApplicationDbContext>(optionsBuilder => {
    if (_connType == "MSSQL")
	{
		_connectionString = builder.Configuration.GetConnectionString("MsSqlDevDB");
		optionsBuilder.UseSqlServer(_connectionString);
    }
    else if (_connType == "MYSQL")
	{
		_connectionString = builder.Configuration.GetConnectionString("MySqlDevDB");
		optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
	}
});

builder.Services.AddScoped<IRepo<Course>, CourseRepo>();

builder.Services.AddScoped<IRepo<Course>, EntityRepo<Course>>();

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