using Microsoft.Extensions.DependencyInjection;
using MyBlazorApp.Net;
using MyBlazorApp.Net.Api;

public static class ServiceExtensions
{
    public static IServiceCollection AddNetApi(this IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastApi, WeatherForecastApi>();

        return services;
    }
}
