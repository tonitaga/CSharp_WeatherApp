using WeatherApp.Controller;

namespace WeatherApp
{
    public partial class WeatherView : Form
    {
        private WeatherController _controller;

        public WeatherView(WeatherController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void SendWeatherRequestButton_Click(object sender, EventArgs e)
        {
            if (cityName.Text.Length == 0)
                return;

            _controller.SendRequest(city: cityName.Text);
            if (_controller.RequestIsSuccessfull())
            {
                SetGoodResponse();
                return;
            }

            SetBadResponse();
        }

        private void SetBadResponse()
        {
            string notAvailable = "N/A";
            string badStatus = "Entered City Doesn't Exists";

            temp.Text = notAvailable;
            tempMin.Text = notAvailable;
            tempMax.Text = notAvailable;
            tempFeelsLike.Text = notAvailable;

            weather.Text = notAvailable;
            weatherDescription.Text = notAvailable;

            wind.Text = notAvailable;
            windDegree.Text = notAvailable;
            windGust.Text = notAvailable;

            status.Text = badStatus;
        }

        private void SetGoodResponse()
        {
            var response = _controller.GetResponse();

            temp.Text = response.main.temp.ToString();
            tempMin.Text = response.main.temp_min.ToString();
            tempMax.Text = response.main.temp_max.ToString();
            tempFeelsLike.Text = response.main.feels_like.ToString();

            weather.Text = response.weather[0].main;
            weatherDescription.Text = response.weather[0].description;

            wind.Text = response.wind.speed.ToString();
            windDegree.Text = response.wind.deg.ToString();
            windGust.Text = response.wind.gust.ToString();

            status.Text = "Successfull";
        }
    }
}