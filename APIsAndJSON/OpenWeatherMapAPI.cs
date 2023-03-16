using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq; 

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        private HttpClient _client;
        public string key = "3286af5bd843f275d8cec866606a7ffd";
        public OpenWeatherMapAPI(HttpClient client) 
        {
            _client = client;
        }

        public string GetWeatherDetails(string cityName)
        {
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=imperial&appid={key}";

            var weatherRes = _client.GetStringAsync(weatherURL).Result;

            var weather = JObject.Parse(weatherRes).GetValue("main").ToString();

            return $"The current weather in {cityName} is as follows: {weather}";
        }
    }
}
