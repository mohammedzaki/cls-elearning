using ELearningApp.Data;
using ELearningApp.Data.Entities;
using ELearningApp.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("SqlServer");

builder.Services.AddDbContext<ApplicationDbContext>(mysetting => {
    mysetting.UseSqlServer(connectionString, b => b.MigrationsAssembly("ELearningApp.Migrations"));
});

var app = builder.Build();

app.UseStaticFiles();

app.UseSession();

app.UseRouting();

app.Run();
