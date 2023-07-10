using Microsoft.EntityFrameworkCore;
using Src.Domain.Entities;

namespace Src.Database;

public class EshopDatabase : DbContext
{
    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    public EshopDatabase(DbContextOptions<EshopDatabase> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("Eshop_Db");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}

public static class DbExtension
{
    public static IServiceCollection AddEshopDb(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<EshopDatabase>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("Postgres"));
        });
        return services;
    }
}