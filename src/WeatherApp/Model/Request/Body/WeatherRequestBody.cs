using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.Request.Body
{
    // Класс WeatherRequestBody
    // Содержит тело запроса для сервиса OpenWeatherMap
    public class WeatherRequestBody
    {
        public WeatherRequestBody(string cityName = "") 
        {
            city = cityName;
        }

        public string city { get; set; } = "";
    }
}
