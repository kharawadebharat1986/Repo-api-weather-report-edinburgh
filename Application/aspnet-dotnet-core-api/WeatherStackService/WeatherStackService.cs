using aspnet_dotnet_core_api.WeatherStackService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace aspnet_dotnet_core_api.WeatherStackService
{
    public class WeatherStackService: IWeatherStackService
    {
        private HttpClient _httpClient;

        public WeatherStackService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> getWeatherFromWeatherStack(string City)
        {
            string apiResponse = string.Empty;
            try
            {
                string url = string.Format("{0}{1}", "http://api.weatherstack.com/current?access_key=7cfcb4becc8401eeee31e19ef8e80541&query=", City);
                using (var response = await _httpClient.GetAsync(url))
                {
                    apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                apiResponse = "{'Error':'"+ ex.Message +"'}";
            }            
            return apiResponse;
        }
    }
}
