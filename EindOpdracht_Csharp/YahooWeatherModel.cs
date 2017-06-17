using System;
using System.Text;
using System.Net;
using System.Web;
using Newtonsoft.Json.Linq;

namespace EindOpdracht_Csharp
{
    public class YahooWeatherModel
    {
        
        private string RawApiData { get; set; }

        private JObject ApiJson { get; set; }
        
        private JArray ApiResult { get; set; }

        private DateTime ApiCallTime { get; set; }

        public void GetCurrentWeather()
        {
            using( WebClient webClient = new WebClient())
            {
                RawApiData = webClient.DownloadString(@"https://query.yahooapis.com/v1/public/yql?q=" +
                    @"select%20item.condition%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22Emmen%2C%20NL%22)&" +
                    @"format=json&u=c"
                );
            }
        }
    }
}