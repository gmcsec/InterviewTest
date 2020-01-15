using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest.REST
{
    public class WebRequest
    {
        const string APIKey = "6cdc97956bc9585c71e2b07b81f158fe";
        const string BaseURL = "http://api.openweathermap.org/data/2.5/";

        public HttpResponseMessage GetCurrentWeather(string zip)
        {
            HttpClient Request = new HttpClient();
            Request.BaseAddress = new Uri(BaseURL);
            string Parameters = "weather?zip=" + zip + "&units=imperial&appid=" + APIKey;
            return Request.GetAsync(Parameters).Result;
        }

        public JValue GetCurrentWeather2(string zip)
        {
            HttpClient Request = new HttpClient();
            Request.BaseAddress = new Uri(BaseURL);
            string Parameters = "weather?zip=" + zip + "&units=imperial&appid=" + APIKey;
            return (JValue)Request.GetAsync(Parameters).Result.Content.ReadAsStringAsync().Result;
        }

        public Task<string> GetCurrentWeatherDetails(string zip)
        {
            HttpClient Request = new HttpClient();
            Request.BaseAddress = new Uri(BaseURL);
            string Parameters = "weather?zip=" + zip + "&units=imperial&appid=" + APIKey;
            return Request.GetStringAsync(Parameters);

        }

        public async Task<JObject> GetCurrentWeatherDetails2(string zip)
        {
            string Parameters = BaseURL + "weather?zip=" + zip + "&units=imperial&appid=" + APIKey;
            var httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri(BaseURL);
            var Content = await httpClient.GetStringAsync(Parameters);
            var Response = await Task.Run(() => JObject.Parse(Content));
            return Response;
        }
    }
}
