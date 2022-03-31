using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnet_dotnet_core_api.WeatherStackService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aspnet_dotnet_core_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherStackService _weatherService;
        public WeatherForecastController(ILogger<WeatherForecastController> logger,IWeatherStackService weatherReport)
        {
            _logger = logger;
            _weatherService = weatherReport;
        }

        [HttpGet]
        public string Get(string strCity)
        {   
            return _weatherService.getWeatherFromWeatherStack(strCity);
        }
    }
}
