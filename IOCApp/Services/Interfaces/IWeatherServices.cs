namespace IOCApp.Services.Interfaces
{
    public interface IWeatherServices
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts();
    }
}
