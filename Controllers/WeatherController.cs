using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeatherApi.Services;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("current")]
        public async Task<IActionResult> GetCurrentWeather(string city)
        {
            var weather = await _weatherService.GetCurrentWeatherAsync(city);
            if (weather == null) return NotFound();
            return Ok(weather);
        }

        [HttpGet("forecast")]
        public async Task<IActionResult> GetForecast(string city)
        {
            var forecast = await _weatherService.GetForecastAsync(city);
            if (forecast == null) return NotFound();
            return Ok(forecast);
        }
    }
}

