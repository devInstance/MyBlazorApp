using Microsoft.Extensions.DependencyInjection;

public static class ServiceExtensions
{
    public static IServiceCollection AddMockAppServices(this IServiceCollection services)
    {
        //services.AddScoped<Interface, Implementation>();

        return services;
    }

    public static IServiceCollection AddMockNetApi(this IServiceCollection service)
    {
        //services.AddScoped<Interface, Implementation>();

        return service;
    }

}
