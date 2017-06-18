using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace EindOpdracht_Csharp
{
    public class YahooWeatherModel
    {
        private string ConfiguredLocation { get; set; }

        private JObject JsonResponseObject { get; set; }

        private string WeatherDataString { get; set; }

        /**
         * This methods will make an call to the Yahoo weather api.
         */
        private void DownloadWeatherData()
        {
            string jsonString;
            using (WebClient webClient = new WebClient())
            {
                WeatherDataString = webClient.DownloadString(
                    @"https://query.yahooapis.com/v1/public/yql?q=" +
                    @"https://query.yahooapis.com/v1/public/yql?q=select%20location%2C%20wind%2C%20atmoshere%2C%20image%2C%20item.condition%20%20from%20weather.forecast%20where%20woeid%20" +
                    @"in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22" +
                    ConfiguredLocation +
                    @"%22)and%20u%3D'c'" +
                    @"format=json"
                );
            }
        }

        /**
         * This method will parse the JSON string send by the api.
         */
        private void ParseWeatherData()
        {
            try
            {
                JsonResponseObject = JObject.Parse(WeatherDataString);
                JsonSchema yahooValidatitionJsonSchema =
                    JsonSchema.Parse(File.ReadAllText("/yahoo-validation-schema.json"));

                if (!JsonResponseObject.IsValid(yahooValidatitionJsonSchema))
                {
                    MessageBox.Show(@"Invalid json send by yahoo api. Please try again later.", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        /**
         * This method will persist weather data into the database.
         */
        private void PersistWeatherData()
        {
            try
            {
                stendenweatherEntities1 stendenWeatherContext = new stendenweatherEntities1();
                var channelData = JsonResponseObject["query"]["results"]["channel"];

                weatherdata newWeatherdata = new weatherdata
                {
                    city = (string) channelData["location"]["city"],
                    country = (string) channelData["location"]["country"],
                    province = (string) channelData["location"]["region"],
                    code = (byte) channelData["item"]["condition"]["code"],
                    text = (string) channelData["item"]["condition"]["text"],
                    temparature = (sbyte) channelData["item"]["condition"]["temp"],
                    humididy = (byte) channelData["atmosphere"]["humididy"],
                    windDirection = (int) channelData["wind"]["direction"],
                    windSpeed = (int) channelData["wind"]["speed"],
                };

                stendenWeatherContext.weatherdata.Add(newWeatherdata);
                stendenWeatherContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        /**
         * This method will download new weather data and persist it into the database.
         */
        public void RefreshWeatherData()
        {
            DownloadWeatherData();
            ParseWeatherData();
            PersistWeatherData();
        }
    }
}