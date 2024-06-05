using System.Threading.Tasks;
using WeatherApi.Models;

namespace WeatherApi.Services
{
    public interface IWeatherService
    {
        Task<WeatherResponse> GetCurrentWeatherAsync(string city);
        Task<ForecastResponse> GetForecastAsync(string city);
    }
}

