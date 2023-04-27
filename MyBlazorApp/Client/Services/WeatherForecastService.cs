using MyBlazorApp.Net.Api;
using MyBlazorApp.Services.Api;
using MyBlazorApp.Services.Model;

namespace MyBlazorApp.Services;

internal class WeatherForecastService : IWeatherForecastService
{
    IWeatherForecastApi Api { get; set; }

    struct SummaryRange
    {
        public SummaryRange(string summary, int min, int max)
        {
            Summary = summary;
            Min = min;
            Max = max;
        }

        public string Summary { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
    
    private static readonly SummaryRange[] Summaries =
    {
        new SummaryRange("Freezing", -200, -10 ),
        new SummaryRange("Bracing",  -10, -2 ),
        new SummaryRange("Chilly",  -2, 5 ),
        new SummaryRange("Cool", 5, 15 ),
        new SummaryRange("Mild", 15, 22 ),
        new SummaryRange("Warm",  22, 27),
        new SummaryRange("Balmy", 27, 32),
        new SummaryRange("Hot", 32, 40),
        new SummaryRange("Sweltering", 40, 50),
        new SummaryRange("Scorching", 50, 120),
    };

    private static string FindSummary(int temperatureC)
    {
        foreach (var summary in Summaries)
        {
            if (temperatureC >= summary.Min && temperatureC <= summary.Max)
            {
                return summary.Summary;
            }
        }
        return "Unknown";
    }

    public WeatherForecastService(IWeatherForecastApi api)
    {
        Api = api;
    }

    public async Task<WeatherForecastItem[]> GetForecastAsync()
    {
        var result = await Api.GetForecastAsync();
        return result.Select(x => new WeatherForecastItem
        {
            Date = x.Date,
            TemperatureC = x.TemperatureC,
            Summary = FindSummary(x.TemperatureC)
        }).ToArray();
    }
}
