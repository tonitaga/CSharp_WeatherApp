using WeatherApp.Model.Request;
using WeatherApp.Model.Request.Body;
using WeatherApp.Model.Response;

namespace WeatherApp.Model
{
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

        public WeatherResponse? GetResponse()
        {
            return _response;
        }

        public void SendRequest(WeatherRequestBody requestBody)
        {
            _response = _requestInstanse.Send(requestBody);

            if (RequestIsSuccessfull())
                _converterInstance.ConvertToCelsiusFromKelvin(_response.main);
        }

        public bool RequestIsSuccessfull()
        {
            if (_response == null)
            {
                return false;
            }

            return _response.cod == 200;
        }

    }
}
