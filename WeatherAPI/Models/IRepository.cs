using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherAPI.OpenWeatherAPI;

namespace WeatherAPI.Models
{
    public interface IRepository
    {
        WeatherResponse GetWeather(string city);
    }
}
