namespace WeatherApp.Model.Response.Body
{
    // Класс WeatherResponseBodyWind
    // Создан для сохранения данных о ветре из JSON файла
    // Наименование полей согласно ответу от сервиса в виде JSON файла
    public class WeatherResponseBodyWind
    {
        public double speed { get; set; }
        public double deg   { get; set; }
        public double gust  { get; set; }
    }
}
