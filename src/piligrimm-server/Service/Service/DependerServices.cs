using Application.Market;
using Models.Market;

namespace Service
{
    public class DependerServices : IoContainer
    {
        public void Load(IServiceCollection services)
        {
            services.AddTransient<IWeatherForecast, WeatherForecastHandler>();
        }
    }
}
