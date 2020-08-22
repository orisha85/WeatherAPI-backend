using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;
using WeatherAPI.OpenWeatherAPI;

namespace WeatherAPI.Models
{
    public class Repository: IRepository
    {
        public WeatherResponse GetWeather(string city)
        {
            string IDOWeather = "ceebe90894558153cb2e918207d87e5a";
            var client = new RestClient($"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&APPID={IDOWeather}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);
                return content.ToObject<WeatherResponse>();
            }

            return null;
        }
    }
}
