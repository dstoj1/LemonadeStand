using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public double lemons;
        public double cups;
        public double ice;
        public double sugar;

        public Store()
        {
        }
        public void SellLemons(Player player)
        {
            Console.WriteLine("How many lemons would you like? \n 10 for $1.50 \n 20 for $3.25 \n 30 for $5.50");
            double Number = double.Parse(Console.ReadLine());
            Number *= 10;
            double price;
            if (Number == 10)
            {
                price = 2.00;
            }
            else if (Number == 20)
            {
                price = 3.50;
            }
            else
            {
                price = 4.25;
            }
            if (price < player.money)
            {
                for (double i = 0; i < Number; i++)
                {
                    Lemons lemon = new Lemons();
                    player.inventory.LemonList.Add(lemon);
                }
                player.money -= price;
            }
            else
            {
                Console.WriteLine("Sorry you don't have enough money.");
                //send back to begining to pick sugar etc.
            }
        }
        public void SellSugar(Player player)
        {
            Console.WriteLine("How much sugar would you like to buy \n 8 cups for $1.25 \n 16 cups for $2.25 \n 32 cups for $4.25");
            double Number = double.Parse(Console.ReadLine());
            Number *= 2;
            double price;
            if (Number == 8)
            {
                price = 1.25;
            }
            else if (Number == 16)
            {
                price = 2.25;
            }
            else
            {
                price = 4.25;
            }
            if (price < player.money)
            {
                for (double i = 0; i < Number; i++)
                {
                    Sugar sugar = new Sugar();
                    player.inventory.SugarList.Add(sugar);
                }
                player.money -= price;
            }
            else
            {
                Console.WriteLine("Sorry you don't have enough money.");
                //send back to begining to pick sugar etc.
            }
        }
        public void SellCups(Player player)
        {
            Console.WriteLine("How many cups would you like \n 25 cups for $.97 \n 50 cups for $1.75 \n 100 cups for $3.16");
            double Number = double.Parse(Console.ReadLine());
            double price;
            Number *= 2;
            if (Number == 25)
            {
                price = .97;
            }
            else if (Number == 50)
            {
                price = 1.75;
            }
            else
            {
                price = 3.16;
            }
            if (price < player.money)
            {
                for (double i = 0; i < Number; i++)
                {
                    Cups cups = new Cups();
                    player.inventory.CupsList.Add(cups);
                }
                player.money -= price;
            }
            else
            {
                Console.WriteLine("Sorry you don't have enough money.");
                //Send back to the begining
            }
        }
        public void SellIce(Player player)
        {
            Console.WriteLine("How much ice would you like to buy \n 125 Ice Cubes for $.97 \n 250 Ice Cube for $2.00 \n 500 Ice Cubes for $4.25 ");
            double Number = double.Parse(Console.ReadLine());
            double price;
            if (Number == 125)
            {
                price = .97;
            }
            else if (Number == 250)
            {
                price = 2.00
            }
            else
            {
                price = 4.25
            }
            if (price < player.money)
            {
                for (double i = 0; i < Number; i++)
                {
                    Ice ice = new Ice();
                    player.inventory.IceList.Add(ice);
                }
                player.money -= price;
            }
            else
            {
                Console.WriteLine("Sorry you don't have enough money.");
                //Send back to the begining
            }
        }
   }
}
