using MyBlazorApp.Net.Api;
using MyBlazorApp.Services.Model;
using MyBlazorApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorApp.Mocks.NetApiMocks
{
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
}
