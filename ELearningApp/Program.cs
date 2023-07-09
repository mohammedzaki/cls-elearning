using ELearningApp.Data;
using ELearningApp.Data.Entities;
using ELearningApp.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var connectionString = builder.Configuration.GetConnectionString("SqlServer");

builder.Services.AddDbContext<ApplicationDbContext>(mysetting => { 
    mysetting.UseSqlServer(connectionString);
});

builder.Services.AddScoped<IRepository<Course>, CourseRepository>();

builder.Services.AddScoped<IRepository<Instructor>, EntityRepository<Instructor>>();
builder.Services.AddScoped<IRepository<Lesson>, EntityRepository<Lesson>>();
builder.Services.AddScoped<IRepository<Student>, EntityRepository<Student>>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
