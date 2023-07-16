using ELearningApp.Data;
using ELearningApp.Data.Entities;
using ELearningApp.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddRazorPages();

var connectionString = builder.Configuration.GetConnectionString("SqlServer");

builder.Services.AddDbContext<ApplicationDbContext>(mysetting => { 
    mysetting.UseSqlServer(connectionString, b => b.MigrationsAssembly("ELearningApp"));
});

builder.Services.AddScoped<IRepository<Course>, CourseRepository>();

builder.Services.AddScoped<IRepository<Instructor>, EntityRepository<Instructor>>();
builder.Services.AddScoped<IRepository<Lesson>, EntityRepository<Lesson>>();
builder.Services.AddScoped<IRepository<Student>, EntityRepository<Student>>();
builder.Services.AddScoped<IRepository<Group>, EntityRepository<Group>>();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(15);
});

var app = builder.Build();

app.UseStaticFiles();

app.UseSession();

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

app.MapRazorPages();

app.Run();
