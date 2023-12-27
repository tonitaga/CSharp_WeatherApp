namespace WeatherApp.Model.Response.Body
{
    // Класс WeatherResponseBodySystem
    // Создан для сохранения системных данных из JSON файла
    // Наименование полей согласно ответу от сервиса в виде JSON файла
    public class WeatherResponseBodySystem
    {
        public uint sunrise { get; set; }
        public uint sunset  { get; set; }
    }
}
