using Portfolio.Scalete.DataAccess.SqlServer;

namespace Portfolio.Scalete.Api;

public static class BasicSolutionDependenciesDependencyInjection
{
    public static IServiceCollection AddBasicSolutionDependencies(this IServiceCollection services)
    {
        services.AddControllers();

        return services
            .AddPersistent()

            .AddEndpointsApiExplorer();
    }
}
