using WeatherApp.Model.Request.Body;
using WeatherApp.Model.Response;
using Newtonsoft.Json;

namespace WeatherApp.Model.Request
{
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

        public static WeatherRequest GetInstance()
        {
            if (_instance == null)
            {
                _instance = new WeatherRequest();
            }

            return _instance;
        }

        public WeatherResponse? Send(WeatherRequestBody requestBody)
        {
            var requestUrl = string.Format(_urlFormat, requestBody.city, _key);
            var response = _httpClient.GetAsync(requestUrl).Result;
            var responseBody = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<WeatherResponse>(responseBody);
        }
    }
}
