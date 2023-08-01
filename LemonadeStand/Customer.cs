using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        public double desireToPurchase;
        public double purchasingThreshold = 100;
        Random rnd = new Random();
        public Customer()
        {
            desireToPurchase = rnd.Next(0, 101);
        }

        public bool decideToPurchase(Day day,Player player)
        {
            desireToPurchase += day.weather.actualTemperature;
            if (day.weather.actualWeatherCondition == "Sunny")
            {
                desireToPurchase += 40;
            }
            else if(day.weather.actualWeatherCondition == "Cloudy")  
            { 
                desireToPurchase -= 50; 
            }
            desireToPurchase -= player.recipe.pricePerCup * 10;
            if (desireToPurchase >= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
