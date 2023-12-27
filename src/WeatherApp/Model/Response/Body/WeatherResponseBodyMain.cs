namespace WeatherApp.Model.Response.Body
{
    // Класс WeatherResponseBodyMain
    // Создан для сохранения основных данных из JSON файла
    // Наименование полей согласно ответу от сервиса в виде JSON файла
    public class WeatherResponseBodyMain
    {
        public double temp       { get; set; }
        public double feels_like { get; set; }
        public double temp_min   { get; set; }
        public double temp_max   { get; set; }
        public double pressure   { get; set; }
        public double humidity   { get; set; }
    }
}
