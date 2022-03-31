using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_dotnet_core_api.WeatherStackService.Interfaces
{
    public interface IWeatherStackService
    {
        string getWeatherFromWeatherStack(string City);
    }
}
