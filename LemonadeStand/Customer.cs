using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public int purchaseChance;
        Weather weather;

        public Customer(Weather weather)
        {
            this.weather = weather;
        }


        public void MakeCustomer()
        {
            Random random = new Random();
            purchaseChance = random.Next(1, 50) + getWeatherEffect() + priceEffect();

        }
        private int getWeatherEffect()
        {
            int weatherEffect;
            switch (weather.Temperature)
            {
                case 86:
                    weatherEffect = 25;
                    break;
                case 81:
                    weatherEffect = 20;
                    break;
                case 78:
                    weatherEffect = 15;
                    break;
                case 65:
                    weatherEffect = 10;
                    break;
                default:
                    break;
                
            }
            return weatherEffect;
        }
    }     
}
