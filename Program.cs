using Wolverine;
using WolverineTest.Modules.Product.Actions;
using WolverineTest.Modules.Product.Store;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddOpenApi()
    .AddControllers();

builder.Host.UseWolverine(x =>
{
    x.Discovery.IncludeAssembly(typeof(Program).Assembly);
});

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IProductRepository, ProductRespository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
