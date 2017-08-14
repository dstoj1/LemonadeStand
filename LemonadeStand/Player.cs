using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Inventory inventory = new Inventory();
        public Store store = new Store();
        public double money = 25.00;
        public double total;
      

        
        public Player()
        {

        }

        Recipe SweetLemonade = new Recipe(5, 2, 10);

        Recipe SourLemonade = new Recipe(6, 1, 10);

        // Money
        //   Starting amount is $25.00
         


     // write a method for list of  lemons
     //public void AddTotal-----from sales of lemonade
     //subtract lemons, sugar, IceCubes from Invento
     //Ice needs to be bought everyday because it melts
        //sugar can be kept for the 7 days without it spoiling


        
           
        //do I pass anything in this method
        //public double DayCount();
        //for(double i =0; i < DayCount; i++)
        // {Console.Write(")}????????

        //
    }
}
