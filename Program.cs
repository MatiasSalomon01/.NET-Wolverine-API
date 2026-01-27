using Wolverine;
using Wolverine.Http;
using WolverineTest.Modules.Product;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddOpenApi()
    .AddControllers();

builder.Host.UseWolverine(x =>
{
    x.Discovery.IncludeAssembly(typeof(ProductEndpoints).Assembly);
});

builder.Services.AddWolverineHttp();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapWolverineEndpoints();

app.Run();
