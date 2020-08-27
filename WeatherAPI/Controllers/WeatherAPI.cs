using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft;
using WeatherAPI.Models;
using WeatherAPI.OpenWeatherAPI;

namespace WeatherAPI.Controllers
{
    [Route("api/WeatherAPI")]
    [ApiController]
    public class WeatherAPI : ControllerBase
    {
        private IRepository _repository;

        [ResponseCache(Duration = 300, Location = ResponseCacheLocation.Any, VaryByQueryKeys = new[] { "city" })]

        [HttpGet("{city}")]
        public ActionResult<WeatherResponse> GetWeather(string city)
        {            
            return _repository.GetWeather(city);
        }

    }
}
