namespace WeatherApp.Model.Response.Body
{
    // Класс WeatherResponseBodyWeather
    // Создан для сохранения данных о погоде из JSON файла
    // Наименование полей согласно ответу от сервиса в виде JSON файла
    public class WeatherResponseBodyWeather
    {
        public string main        { get; set; } = "";
        public string description { get; set; } = "";
    }
}
