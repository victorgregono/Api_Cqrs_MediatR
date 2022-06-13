using ApiCQRS.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiCQRS.Configurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FactoryContext>(options =>
                        options.UseSqlServer(GetApiConnectionString(configuration))
                        .LogTo(Console.WriteLine,LogLevel.Information));
        }

        public static string GetApiConnectionString(IConfiguration configuration)
            => configuration.GetConnectionString("DB_CONNECTION_STRING");
    }
}
