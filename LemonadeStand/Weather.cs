using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public string TodaysWeather;
        public int Temp;
        public Weather()
        {

        }
        public void GetWeather()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 4);
            string[] choices = new string[] { "Sunny", "Partly Cloudy", "Cloudy", "Rainy" };
            TodaysWeather = choices[randomNumber];

        }
        public void MakeWeather()
        {
            switch (TodaysWeather)
            {
                case "Sunny":
                    Console.WriteLine("Sunny and Beautiful \n High 86 Today");
                    Temp = 86;
                    break;
                case "Partly Cloudy":
                    Console.WriteLine("Warm \n High 81");
                    Temp = 81;
                    break;
                case "Cloudy":
                    Console.WriteLine("Cloudy and Muggy \n High 78");
                    Temp = 78;
                    break;
                case "Rainy":
                    Console.WriteLine("Rainy and Cold \n High 65");
                    Temp = 65;
                    break;
                default:
                    break;
            }
        }

    }

}
