using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Player player;
        Inventory inventory;
        Store store;
        Day day;
        Weather weather;
        Customer customer;
        string Supplies;


        public Game()
        {
           player = new Player();
           day = new Day();
           store = new Store();
           weather = new Weather();
        }
        public void GetSupplies()
        {
            Console.WriteLine("What would you like to purchase? \n Lemons \n Sugar \n Ice Cubes \n Cups");
            Supplies = Console.ReadLine().ToLower();

            switch (Supplies)
            {
                case "lemons":
                    store.SellLemons(player);
                    break;
                case "sugar":
                    store.SellSugar(player);
                    break;
                case "ice cubes":
                    store.SellIceCubes(player);
                    break;
                case "cups":
                    store.SellCups(player);
                    break;               
            }
        }
        public void RunGame()
        {
          //  weather.GetWeather();
            //weather.MakeWeather();
            GetSupplies();
        }
    }

    // if start amount is lower then the end amount then there is a loss for the day or week
    // if start amount is higher then the end amount then there is a profit for the day or week
    
    //double sellPrice = 


    //loop many days
    //sell pitcher of Lemonade-----
   
    //if price of the 1.50 4% people will buy it weather it is hot or cold
    //if hot outside and price is 1.00 40% of the people will like it.

    
}  
