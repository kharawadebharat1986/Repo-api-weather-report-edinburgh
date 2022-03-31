using aspnet_dotnet_core_api.WeatherStackService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_dotnet_core_api.WeatherStackService
{
    public class WeatherStackService: IWeatherStackService
    {
        public string getWeatherFromWeatherStack(string City)
        {
            return "{'request':{'type':'City','query':'Edinburgh, United Kingdom','language':'en','unit':'m'},'location':{'name':'Edinburgh','country':'United Kingdom','region':'City of Edinburgh','lat':'55.949','lon':'-3.163','timezone_id':'Europe London','localtime':'2022-03-31 11:29','localtime_epoch':1648726140,'utc_offset':'1.0'},'current':{'observation_time':'10:29 AM','temperature':6,'weather_code':116,'weather_icons':['https://assets.weatherstack.com/images/wsymbols01_png_64/wsymbol_0002_sunny_intervals.png'],'weather_descriptions':['Partly cloudy'],'wind_speed':13,'wind_degree':20,'wind_dir':'NNE','pressure':1019,'precip':0,'humidity':61,'cloudcover':25,'feelslike':2,'uv_index':1,'visibility':10,'is_day':'yes'}}";
        }
    }
}
