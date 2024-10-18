using Microsoft.Extensions.DependencyInjection;

namespace Portfolio.Scalete.DataAccess.SqlServer;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddPersistent(this IServiceCollection services)
    {
        services.AddDbContext<SqlServerDbContext>();

        return services;
    }
}
