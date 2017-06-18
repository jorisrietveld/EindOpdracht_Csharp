using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace EindOpdracht_Csharp
{
    class DatabaseModel
    {
        private stendenweatherEntities1 WeatherContext { get; set; }

        public void PersistWeatherData(string city, string country, string province, byte code, string text, sbyte temparature, byte humididy, int windDirection, int windSpeed)
        {
            try
            {
                weatherdata newWeatherdata = new weatherdata
                {
                    city = city,
                    country = country,
                    province = province,
                    code = code,
                    text = text,
                    temparature = temparature,
                    humididy = humididy,
                    windDirection = windDirection,
                    windSpeed = windSpeed,
                };

                WeatherContext.weatherdata.Add(newWeatherdata);
                WeatherContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        public void PersistWeatherData(JObject jsonResponseData)
        {
            var channelData = jsonResponseData["query"]["results"]["channel"];
            this.PersistWeatherData(
                (string) channelData["location"]["city"],
                (string) channelData["location"]["country"],
                (string) channelData["location"]["region"],
                (byte) channelData["item"]["condition"]["code"],
                (string) channelData["item"]["condition"]["text"],
                (sbyte) channelData["item"]["condition"]["temp"],
                (byte) channelData["atmosphere"]["humididy"],
                (int) channelData["wind"]["direction"],
                (int) channelData["wind"]["speed"]
            );
        }

        public void GetAllWeatherData()
        {
            var fiveDaysArgo = DateTime.Now.AddDays(-5);
            var weatherDataListLastFiveDays = WeatherContext.weatherdata.OrderBy(e => e.created)
                .Where(e => e.created > fiveDaysArgo).Select(w => new weatherdata {
                    id = w.id,
                    city = w.city,
                    country = w.country,
                    province = w.province,
                    code = w.code,
                    text = w.text,
                    temparature = w.temparature,
                    humididy = w.humididy,
                    windDirection = w.windDirection,
                    windSpeed = w.windSpeed,
                    created = w.created
                }).ToList();
        }
    }
}
