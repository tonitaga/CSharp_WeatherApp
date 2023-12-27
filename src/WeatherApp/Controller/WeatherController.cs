using WeatherApp.Model;
using WeatherApp.Model.Request.Body;
using WeatherApp.Model.Response;

namespace WeatherApp.Controller
{
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
