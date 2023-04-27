using MyBlazorApp.Services.Model;

namespace MyBlazorApp.Services.Api;

public interface IWeatherForecastService
{
    Task<WeatherForecastItem[]> GetForecastAsync();
}
