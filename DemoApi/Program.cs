using DemoApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<GreetingService>();

var app = builder.Build();

app.MapGet("/api/hello",
    (GreetingService greeting) => greeting.GetMessage());

app.Run();