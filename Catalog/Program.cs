using Catalog.Database;
using Catalog.Repositories;
using Catalog.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEshopDb(builder.Configuration);
builder.Services.AddTransient<ICategoryRepository, CategoryRepo>();
builder.Services.AddTransient<ICategoryService, CategoryService>();

builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IProductRepository, ProductRepo>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "Catalog Module");
app.MapControllers();
app.Run();

public partial class Program { }