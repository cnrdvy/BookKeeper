using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace BookKeeper.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services,
        Assembly applicationAssembly)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(applicationAssembly);
        });

        return services;
    }
}
