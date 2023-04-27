using MyBlazorApp.Net.Api;
using MyBlazorApp.Shared;
using System.Net.Http.Json;

namespace MyBlazorApp.Net;

internal class WeatherForecastApi : IWeatherForecastApi
{
    HttpClient Http { get; }

    public WeatherForecastApi(HttpClient http)
    {
        Http = http;
    }

    public async Task<WeatherForecast[]> GetForecastAsync()
    {
        return await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }
}
