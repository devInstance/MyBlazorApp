using MyBlazorApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorApp.Services.Model;

public class WeatherForecastItem : WeatherForecast
{
    public string? Summary { get; set; }
}
