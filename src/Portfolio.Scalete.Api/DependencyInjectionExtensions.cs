using Portfolio.Scalete.DataAccess.SqlServer;

namespace Portfolio.Scalete.Api;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddEssentialServices(this IServiceCollection services)
    {
        return services
            .AddPersistent()

            .AddApi();
    }

    public static IServiceCollection AddApi(this IServiceCollection services)
    {
        services.AddControllers();
        return services.AddEndpointsApiExplorer();
    }
}
