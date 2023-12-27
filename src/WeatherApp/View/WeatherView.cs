using WeatherApp.Controller;

namespace WeatherApp
{
    // Класс WeatherView
    // Является частью бизнес-логики в паттерне Model-View-Controller
    // Конструируется от контроллера
    // Бизнес логика вызывается и хранится только в модели
    // Общение с логикой происходит непременно через контроллер

    public partial class WeatherView : Form
    {
        private WeatherController _controller;

        public WeatherView(WeatherController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        // Метод отвечающий за сигнал по нажатию на основную кнопку
        private void SendWeatherRequestButton_Click(object sender, EventArgs e)
        {
            if (cityName.Text.Length == 0)
                return;

            // Отправляем данные по запросу через контроллер в модель
            _controller.SendRequest(city: cityName.Text);

            // Если запрос успешен, то выводит данные
            if (_controller.RequestIsSuccessfull())
            {
                SetGoodResponse();
                return;
            }

            // Иначе, приводит все информационные панели в начальный вид
            SetBadResponse();
        }

        // Метод для установки плохого запроса
        private void SetBadResponse()
        {
            string notAvailable = "N/A";
            string badStatus = "Entered City Doesn't Exists";

            temp.Text = notAvailable;
            tempMin.Text = notAvailable;
            tempMax.Text = notAvailable;
            tempFeelsLike.Text = notAvailable;
            pressure.Text = notAvailable;
            humidity.Text = notAvailable;

            weather.Text = notAvailable;
            weatherDescription.Text = notAvailable;

            wind.Text = notAvailable;
            windDegree.Text = notAvailable;
            windGust.Text = notAvailable;

            status.Text = badStatus;
        }

        // Метод для установки успешного запроса
        private void SetGoodResponse()
        {
            // Получаем ссылку на ответ по запросу
            var response = _controller.GetResponse();

            temp.Text = response.main.temp.ToString();
            tempMin.Text = response.main.temp_min.ToString();
            tempMax.Text = response.main.temp_max.ToString();
            tempFeelsLike.Text = response.main.feels_like.ToString();
            pressure.Text = response.main.pressure.ToString();
            humidity.Text = response.main.humidity.ToString();

            weather.Text = response.weather[0].main;
            weatherDescription.Text = response.weather[0].description;

            wind.Text = response.wind.speed.ToString();
            windDegree.Text = response.wind.deg.ToString();
            windGust.Text = response.wind.gust.ToString();

            status.Text = "Successfull";
        }
    }
}