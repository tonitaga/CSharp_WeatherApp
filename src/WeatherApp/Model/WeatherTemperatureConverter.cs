using WeatherApp.Model.Response.Body;

namespace WeatherApp.Model
{
    public class WeatherTemperatureConverter
    {
        private static WeatherTemperatureConverter _instance;

        private WeatherTemperatureConverter() { }

        public static WeatherTemperatureConverter GetInstance()
        {
            if (_instance == null)
            {
                _instance = new WeatherTemperatureConverter();
            }

            return _instance;
        }

        public void ConvertToCelsiusFromKelvin(WeatherResponseBodyMain main)
        {
            double kelvin = 273.15;

            main.temp = Math.Round(main.temp - kelvin, 2);
            main.temp_min = Math.Round(main.temp_min - kelvin, 2);
            main.temp_max = Math.Round(main.temp_max - kelvin, 2);
            main.feels_like = Math.Round(main.feels_like - kelvin, 2);
        }
    }
}
