using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToreBrew
{
    public class Weather
    {
        public Weather(string location)
        {
            Location = location;
        }

        public string Location { get; set; }

        public string GetWeather()
        {
            var weatherDetail = $"{Location} , {DateTime.Now} \n" +
                   $"Precipitation: 5 % \nHumidity: 82 % \nWind: 8 km / h";
            return weatherDetail;
        }

    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
