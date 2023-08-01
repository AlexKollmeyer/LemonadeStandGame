using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {
        public string actualWeatherCondition;
        public int actualTemperature;
        public int predictedTemperature;
        public int temperature;
        public List<string> weatherConditions;
        public string predictedForecast;
        public string predictedWeather;
        public string actualWeather;
        
        Random rnd = new Random();
        public Weather()
        {
            weatherConditions = new List<string> { "Rainy", "Cloudy", "Sunny" };
            predictedWeather = weatherConditions[rnd.Next(0, 3)];
            predictedTemperature = rnd.Next(50, 101);
            predictedForecast = $"Forecast is {this.predictedTemperature} degrees and {this.predictedWeather}";
        }

        public void displayPredictedForecast()
        {
            Console.WriteLine(this.predictedForecast);
        }
        public void setAcutalWeather()
        {
            int num=rnd.Next(0, 2);
            if (num == 1)
            {
                this.actualWeatherCondition = weatherConditions[rnd.Next(0, 3)];
                this.actualTemperature = rnd.Next(50, 90);

            }
            else
            {
                this.actualWeatherCondition = predictedWeather;
                this.actualTemperature = predictedTemperature;
            }
            
        }
        public void displayActualForecast()
        {
            Console.WriteLine($"The actual weather is {this.actualTemperature}");

        }
    }
}
