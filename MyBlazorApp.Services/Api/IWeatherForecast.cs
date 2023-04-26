using MyBlazorApp.Shared;

namespace MyBlazorApp.Services.Api;

public interface IWeatherForecast
{
    Task<WeatherForecast[]> GetForecastAsync();
}
