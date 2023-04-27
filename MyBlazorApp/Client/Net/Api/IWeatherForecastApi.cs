using MyBlazorApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorApp.Net.Api
{
    public interface IWeatherForecastApi
    {
        Task<WeatherForecast[]> GetForecastAsync();
    }
}
