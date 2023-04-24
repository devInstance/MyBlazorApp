using Microsoft.Extensions.DependencyInjection;

public static class ServiceExtensions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        //services.AddScoped<Interface, Implementation>();

        return services;
    }

}

