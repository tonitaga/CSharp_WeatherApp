using WeatherApp.Model;
using WeatherApp.Controller;


namespace WeatherApp
{
    internal static class main
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Model-View-Controller Design Pattern
            var model = new WeatherModel();
            var controller = new WeatherController(model);
            var view = new WeatherView(controller);

            Application.Run(view);
        }
    }
}