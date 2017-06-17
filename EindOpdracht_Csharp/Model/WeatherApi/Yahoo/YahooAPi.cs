namespace EindOpdracht_Csharp.Model.WeatherApi.Yahoo
{
    public class YahooAPi : IApi
    {

        public IWeatherData GetWeatherData()
        {
            return new YahooWeaterData();
        }
    }
}