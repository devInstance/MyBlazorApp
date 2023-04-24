using Microsoft.Extensions.DependencyInjection;

public static class ServiceExtensions
{
    public static IServiceCollection AddNetApi(this IServiceCollection service)
    {
        //services.AddScoped<Interface, Implementation>();

        return service;
    }
}
