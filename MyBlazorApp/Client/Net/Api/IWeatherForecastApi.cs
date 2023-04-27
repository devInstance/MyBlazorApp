using MyBlazorApp.Shared;

namespace MyBlazorApp.Net.Api;

public interface IWeatherForecastApi
{
    Task<WeatherForecast[]> GetForecastAsync();
}
