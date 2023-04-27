using MyBlazorApp.Net.Api;
using MyBlazorApp.Shared;

namespace MyBlazorApp.Mocks.NetApiMocks;

internal class WeatherForecastApiMock : IWeatherForecastApi
{
    public async Task<WeatherForecast[]> GetForecastAsync()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
        }).ToArray();
    }
}
