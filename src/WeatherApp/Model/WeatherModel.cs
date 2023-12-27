using WeatherApp.Model.Request;
using WeatherApp.Model.Request.Body;
using WeatherApp.Model.Response;

namespace WeatherApp.Model
{
    // Класс WeatherModel
    // Является частью бизнес-логики в паттерне Model-View-Controller
    // Оформлен в стиле паттерна Facade
    // Объединяет работу всего функционала в общий класс и методы
    // Облегчает управление над всем функционалом
    public class WeatherModel
    {
        private WeatherRequest   _requestInstanse;
        private WeatherResponse? _response;
        private WeatherTemperatureConverter _converterInstance;

        public WeatherModel()
        {
            _requestInstanse = WeatherRequest.GetInstance();
            _converterInstance = WeatherTemperatureConverter.GetInstance();
        }

        // Метод для получения ответа по погоде
        public WeatherResponse? GetResponse()
        {
            return _response;
        }

        // Метод для отправки запроса на получение погоды
        public void SendRequest(WeatherRequestBody requestBody)
        {
            _response = _requestInstanse.Send(requestBody);

            // Если запрос успешен, конвертируем температуру в градусы Цельсия из Кельвинов
            if (RequestIsSuccessfull())
                _converterInstance.ConvertToCelsiusFromKelvin(_response.main);
        }

        // Метод для проверки успешности последнего запроса
        public bool RequestIsSuccessfull()
        {
            if (_response == null)
            {
                return false;
            }

            // Код 200 указывает на успешный запрос
            return _response.cod == 200;
        }

    }
}
