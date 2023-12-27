using WeatherApp.Model.Request.Body;
using WeatherApp.Model.Response;
using Newtonsoft.Json;

namespace WeatherApp.Model.Request
{
    // Класс WeatherRequest
    // Оформлен в стиле паттерна Singleton
    // Обеспечивает глобальную область видимости
    // Гарантирует, что объект данного класса будет создан в единственном экземпляре
    internal class WeatherRequest
    {
        private static WeatherRequest _instance;

        private string _key = "f978906835ab6f3a8f6f2412123cac4e";
        private string _urlFormat = "https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}";

        private HttpClient _httpClient;

        private WeatherRequest()
        {
            _httpClient = new HttpClient();
        }

        // Метод для получения экземляра класса WeatherRequest
        public static WeatherRequest GetInstance()
        {
            if (_instance == null)
            {
                _instance = new WeatherRequest();
            }

            return _instance;
        }

        // Метод для отправки запроса на получение погоды
        public WeatherResponse? Send(WeatherRequestBody requestBody)
        {
            // Формирование URL-адреса запроса с использованием переданных данных
            var requestUrl = string.Format(_urlFormat, requestBody.city, _key);

            // Отправка асинхронного GET-запроса на указанный URL-адрес
            var response = _httpClient.GetAsync(requestUrl).Result;

            // Получение тела ответа в виде строки
            var responseBody = response.Content.ReadAsStringAsync().Result;

            // Десериализация тела ответа в объект WeatherResponse с использованием Newtonsoft.Json
            return JsonConvert.DeserializeObject<WeatherResponse>(responseBody);
        }
    }
}
