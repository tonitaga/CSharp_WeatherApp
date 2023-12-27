using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.Response.Body
{
    // Класс WeatherResponseBodyCoord
    // Создан для сохранения данных о координатах из JSON файла
    // Наименование полей согласно ответу от сервиса в виде JSON файла
    public class WeatherResponseBodyCoord
    {
        public double lon {  get; set; }
        public double lat { get; set; }
    }
}
