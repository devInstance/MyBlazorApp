using MyBlazorApp.Services.Api;
using MyBlazorApp.Services.Model;

namespace MyBlazorApp.Mocks.ServicesMocks;

internal class WeatherForecastServiceMock : IWeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public async Task<WeatherForecastItem[]> GetForecastAsync()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecastItem
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        }).ToArray();
    }
}
