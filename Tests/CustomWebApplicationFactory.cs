using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Src.Infrastructure.Database;

namespace Tests;

public class CustomWebApplicationFactory : WebApplicationFactory<Src.Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        base.ConfigureWebHost(builder);
        builder.UseEnvironment("Test");
        builder.ConfigureServices(services =>
        {
            var myCustomDbContext = services.SingleOrDefault(descriptor =>
                descriptor.ServiceType == typeof(DbContextOptions<EshopDatabase>));
            if (myCustomDbContext == null) return;
            services.Remove(myCustomDbContext);
            services.AddDbContext<EshopDatabase>(options => options.UseInMemoryDatabase("testing_db"));
        });
    }
}