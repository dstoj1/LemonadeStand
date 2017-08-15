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
        public void SellLemons(Player player, double Number)
        {
            double total;
            if (Number == 10)
            {
                total = 1.50;
            }
            else if (Number == 20)
            {
                total = 3.25;
            }
            else if (Number == 30)
            {
                total = 5.50;
            }
            else
            {
                Console.WriteLine("Incorrect Amount, Please try again");
                total = 0;
                SellLemons(player, Number);
            }
            if (player.wallet.RemoveMoney(total))
            {
                player.inventory.AddLemon(Number);
            }  
        }
        public void SellSugar(Player player, double Number)
        {                   
            double total;
            if (Number == 8)
            {
                total = 1.25;
            }
            else if (Number == 16)
            {
                total = 2.25;
            }
            else if (Number == 32)
            {
                total = 4.25;
            }
            else
            {
                Console.WriteLine("Incorrect Amount, Please try again");
                total = 0;
                SellSugar(player, Number);
            }
            if (player.wallet.RemoveMoney(total))
            {
                player.inventory.AddSugar(Number);
            }
        }
        public void SellCups(Player player, double Number)
        {
            double total;      
            if (Number == 25)
            {
                total = .97;
            }
            else if (Number == 50)
            {
                total = 1.75;
            }
            else if (Number == 100)
            {
                total = 3.16;
            }
            else
            {
                Console.WriteLine("Incorrect Amount, Please try again");
                total = 0;
                SellCups(player, Number);
            }     
            if(player.wallet.RemoveMoney(total))
            {
                player.inventory.AddCups(Number);
            }
        }
        public void SellIceCubes(Player player, double Number)
        {           
            double total;
            if (Number == 125)
            {
                total = .97;
            }
            else if (Number == 250)
            {
                total = 2.00;
            }
            else if(Number == 500)
            {
                total = 4.25;
            }
            else
            {
                Console.WriteLine("Incorrect Amount, Please try again");
                total = 0;
                SellIceCubes(player, Number);
            }
            if (player.wallet.RemoveMoney(total))
            {
                player.inventory.AddIce(Number);
            }
        }
        public void GetSupplies(Player player)
        {
          bool counter = true;
             do
              {
                Console.WriteLine("What would you like to purchase? \n Lemons \n Sugar \n Ice Cubes \n Cups");
                Supplies = Console.ReadLine().ToLower();
                double Number;
                switch (Supplies)
                {
                    
                    case "lemons":
                        Console.WriteLine("How many lemons would you like? \n 10 for $1.50 \n 20 for $3.25 \n 30 for $5.50");
                        Number = double.Parse(Console.ReadLine());
                        SellLemons(player, Number);
                        break;
                    case "sugar":
                        Console.WriteLine("How much sugar would you like to buy \n 8 cups for $1.25 \n 16 cups for $2.25 \n 32 cups for $4.25");
                        Number = double.Parse(Console.ReadLine());
                        SellSugar(player, Number);
                        break;
                    case "ice cubes":
                        Console.WriteLine("How many cups would you like \n 25 cups for $.97 \n 50 cups for $1.75 \n 100 cups for $3.16");
                        Number = double.Parse(Console.ReadLine());
                        SellIceCubes(player, Number);
                        break;
                    case "cups":
                        Console.WriteLine("How many cups would you like \n 25 cups for $.97 \n 50 cups for $1.75 \n 100 cups for $3.16");
                        Number = double.Parse(Console.ReadLine());
                        SellCups(player, Number);
                        break;
                    default:
                        Console.WriteLine("Continue");
                        continue;
                }
            } while(counter);
        }
    }
}
