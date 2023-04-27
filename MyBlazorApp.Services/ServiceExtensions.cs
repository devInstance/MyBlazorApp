using Microsoft.Extensions.DependencyInjection;
using MyBlazorApp.Services;
using MyBlazorApp.Services.Api;

public static class ServiceExtensions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastService, WeatherForecastService>();

        return services;
    }
}
