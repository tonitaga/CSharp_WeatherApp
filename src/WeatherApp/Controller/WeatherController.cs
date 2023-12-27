using WeatherApp.Model;
using WeatherApp.Model.Request.Body;
using WeatherApp.Model.Response;

namespace WeatherApp.Controller
{
    // Класс WeatherController
    // Является частью бизнес-логики в паттерне Model-View-Controller
    // Конструируется от модели и делегирует методы модели в своих одноименных
    public class WeatherController
    {
        private WeatherModel _model;

        public WeatherController(WeatherModel model)
        {
            _model = model;
        }

        public WeatherResponse? GetResponse()
        {
            return _model.GetResponse();
        }

        public void SendRequest(string city)
        {
            _model.SendRequest(new WeatherRequestBody(city));
        }

        public bool RequestIsSuccessfull()
        {
            return _model.RequestIsSuccessfull();
        }
    }
}
