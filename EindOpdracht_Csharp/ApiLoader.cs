using System;
using System.Text;
using System.Net;
using System.Web;
using Newtonsoft.Json.Linq;

namespace EindOpdracht_Csharp
{
    public class ApiLoader
    {
        private StringBuilder ApiCallString { get; set; }
        private string RawApiData { get; set; }

        private JObject ApiJson { get; set; }
        
        private JArray ApiResult { get; set; }

        private DateTime ApiCallTime { get; set; }

        protected void BuildYahooWeatherQueryString()
        {
            ApiCallString = new StringBuilder();
            ApiCallString.Append("https://query.yahooapis.com/v1/public/yql?q=");
            ApiCallString.Append("select * from weather.forecast where woeid in 729104 and u='c'");
            ApiCallString.Append("&format=json");
            ApiCallString.Append("&u=c");
        }

        public void GetCurrentWeather()
        {
            using( WebClient webClient = new WebClient())
            {
                RawApiData = webClient.DownloadString(@"https://query.yahooapis.com/v1/public/yql?q=" +
                    @"select%20item.condition%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22Emmen%2C%20NL%22)&" +
                    @"format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&callback=&u=c"
                );
            }
        }
    }
}