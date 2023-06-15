var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var app = builder.Build();

//Start to configure app services

app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();

app.UseRouting();

app.Run();
