namespace Application
{
    public class DependerServices : IoContainer
    {
        public void Load(IServiceCollection services)
        {
            services.AddTransient<IWeatherForecast, WeatherForecastHandler>();
        }
    }
}
