using Microsoft.Extensions.DependencyInjection;

namespace Application;
public static class DependecyInjection
{   
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<MediatREntry>());
        
        return services;
    }
}