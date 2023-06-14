using Catalog.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ICategoryRepository, CatetgoryInMemoryRepo>();

builder.Services.AddControllers();

var app = builder.Build();
    
app.MapGet("/", () => "Catalog Module");
app.MapControllers();
app.Run();

