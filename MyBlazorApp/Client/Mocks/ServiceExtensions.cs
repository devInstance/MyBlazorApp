using Microsoft.Extensions.DependencyInjection;
using MyBlazorApp.Mocks.NetApiMocks;
using MyBlazorApp.Mocks.ServicesMocks;
using MyBlazorApp.Net.Api;
using MyBlazorApp.Services.Api;

public static class ServiceExtensions
{
    public static IServiceCollection AddMockAppServices(this IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastService, WeatherForecastServiceMock>();

        return services;
    }

    public static IServiceCollection AddMockNetApi(this IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastApi, WeatherForecastApiMock>();

        return services;
    }
}
