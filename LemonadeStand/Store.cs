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
        public double iceCubes;
        public double sugar;
        public string Supplies;

        public Store()
        {
        }
        public void SellLemons(Player player)
        {
            Console.WriteLine("How many lemons would you like? \n 10 for $1.50 \n 20 for $3.25 \n 30 for $5.50");
            double Number = double.Parse(Console.ReadLine());
            double price;
            if (Number == 10)
            {
                price = 1.50;
            }
            else if (Number == 20)
            {
                price = 3.25;
            }
            else if (Number == 30)
            {
                price = 5.50;
            }
            else
            {
                Console.WriteLine("Incorrect Amount, Please try again");
                price = 0;
                SellLemons(player);
            }
            if (price < player.money)
            {
                for (double i = 0; i < Number; i++)
                {
                    Lemon lemon = new Lemon();
                    player.inventory.LemonList.Add(lemon);
                }
                player.money -= price;
                Console.WriteLine(player.money);
                
                
            }
            else
            {
                Console.WriteLine("Sorry you don't have enough money.");
                GetSupplies(player);
            }
        }
        public void SellSugar(Player player)
        {
            Console.WriteLine("How much sugar would you like to buy \n 8 cups for $1.25 \n 16 cups for $2.25 \n 32 cups for $4.25");
            double Number = double.Parse(Console.ReadLine());           
            double price;
            if (Number == 8)
            {
                price = 1.25;
            }
            else if (Number == 16)
            {
                price = 2.25;
            }
            else if (Number == 32)
            {
                price = 4.25;
            }
            else
            {
                Console.WriteLine("Incorrect Amount, Please try again");
                price = 0;
                SellSugar(player);
            }
            if (price < player.money)
            {
                for (double i = 0; i < Number; i++)
                {
                    Sugar sugar = new Sugar();
                    player.inventory.SugarList.Add(sugar);
                }
                player.money -= price;
                Console.WriteLine(player.money);
       
            }
            else
            {
                Console.WriteLine("Sorry you don't have enough money.");
                GetSupplies(player);
            }
        }
        public void SellCups(Player player)
        {
            Console.WriteLine("How many cups would you like \n 25 cups for $.97 \n 50 cups for $1.75 \n 100 cups for $3.16");
            double Number = double.Parse(Console.ReadLine());
            double price;      
            if (Number == 25)
            {
                price = .97;
            }
            else if (Number == 50)
            {
                price = 1.75;
            }
            else if (Number == 100)
            {
                price = 3.16;
            }
            else
            {
                Console.WriteLine("Incorrect Amount, Please try again");
                price = 0;
                SellCups(player);
            }
            if (price < player.money)
            {
                for (double i = 0; i < Number; i++)
                {
                    Cups cups = new Cups();
                    player.inventory.CupsList.Add(cups);
                }
                player.money -= price;
                Console.WriteLine(player.money);
            }
            else
            {
                Console.WriteLine("Sorry you don't have enough money.");
                GetSupplies(player);
            }
        }
        public void SellIceCubes(Player player)
        {
            Console.WriteLine("How many ice cubes would you like to buy \n 125 Ice Cubes for $.97 \n 250 Ice Cube for $2.00 \n 500 Ice Cubes for $4.25 ");
            double Number = double.Parse(Console.ReadLine());
            double price;
            if (Number == 125)
            {
                price = .97;
            }
            else if (Number == 250)
            {
                price = 2.00;
            }
            else if(Number == 500)
            {
                price = 4.25;
            }
            else
            {
                Console.WriteLine("Incorrect Amount, Please try again");
                price = 0;
                SellIceCubes(player);
            }
            if (price < player.money)
            {
                for (double i = 0; i < Number; i++)
                {
                    Ice ice = new Ice();
                    player.inventory.IceList.Add(ice);
                }
                player.money -= price;
                Console.WriteLine(player.money);
            }
            else
            {
                Console.WriteLine("Sorry you don't have enough money.");
                GetSupplies(player);
            }
        }
        public void GetSupplies(Player player)
        {
            Console.WriteLine("What would you like to purchase? \n Lemons \n Sugar \n Ice Cubes \n Cups");
            Supplies = Console.ReadLine().ToLower();

            switch (Supplies)
            {
                case "lemons":
                    SellLemons(player);
                    break;
                case "sugar":
                    SellSugar(player);
                    break;
                case "ice cubes":
                    SellIceCubes(player);
                    break;
                case "cups":
                    SellCups(player);
                    break;
            }
        }
    }
}
