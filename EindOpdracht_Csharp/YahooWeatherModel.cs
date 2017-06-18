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

        private void GetCurrentWeather()
        {
            string jsonString;
            using ( WebClient webClient = new WebClient())
            {
                jsonString = webClient.DownloadString(
                    @"https://query.yahooapis.com/v1/public/yql?q=" +
                    @"https://query.yahooapis.com/v1/public/yql?q=select%20location%2C%20wind%2C%20atmoshere%2C%20image%2C%20item.condition%20%20from%20weather.forecast%20where%20woeid%20" +
                    @"in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22" +
                    ConfiguredLocation +
                    @"%22)and%20u%3D'c'" +
                    @"format=json"
                );
                //https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22Emmen%2C%20NL%22)

                JsonResponseObject = JObject.Parse(jsonString);
                JsonSchema yahooValidatitionJsonSchema = JsonSchema.Parse(File.ReadAllText("/yahoo-validation-schema.json"));

                if (!JsonResponseObject.IsValid(yahooValidatitionJsonSchema))
                {
                    MessageBox.Show("Invalid json send by yahoo api.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    JsonResponseObject = null;
                }
            }
        }

        private void SaveData()
        {
            if (JsonResponseObject == null)
            {
                return;
            }

            stendenweatherEntities stendenWeatherContext = new stendenweatherEntities();
            var weatherDataEntity = stendenWeatherContext.weatherdata.Where( c => c.city == ) 
            
        }
    }
}