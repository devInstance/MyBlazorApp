using Microsoft.Extensions.DependencyInjection;
using MyBlazorApp.Mocks.ServicesMocks;
using MyBlazorApp.Services.Api;

public static class ServiceExtensions
{
    public static IServiceCollection AddMockAppServices(this IServiceCollection services)
    {
        services.AddScoped<IWeatherForecast, WeatherForecastMock>();

        return services;
    }

    public static IServiceCollection AddMockNetApi(this IServiceCollection service)
    {
        //services.AddScoped<Interface, Implementation>();

        return service;
    }

}
