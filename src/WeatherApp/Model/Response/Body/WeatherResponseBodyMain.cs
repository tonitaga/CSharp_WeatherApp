namespace WeatherApp.Model.Response.Body
{
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
