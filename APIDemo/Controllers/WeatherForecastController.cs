using Microsoft.AspNetCore.Mvc;

namespace APIDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            //string val = "1 item only";
            List<string> val = new List<string>();
            foreach (var i in Summaries)
            {
                val.Add($"The value is coming out to be: {i}");
            }

            return Ok(val);
        }

        [HttpGet(Name = "GetRandomGUID")]
        public IActionResult GetRandomGUID()
        {
            

            return Ok("val");
        }
    }
}
