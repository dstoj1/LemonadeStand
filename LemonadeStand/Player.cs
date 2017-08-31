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
        public Wallet wallet = new Wallet();         
        public double count = 0;
      

        
        public Player()
        {

        }

        Recipe SweetLemonade = new Recipe(5, 2, 10);

        Recipe SourLemonade = new Recipe(6, 1, 10);

        public int getPriceEffect()
        {
            int priceEffect;
            double cost;
            if(cost == 1.00)
            {
                priceEffect = 23;
            }
        }

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
