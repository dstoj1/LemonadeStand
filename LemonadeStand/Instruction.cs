using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Instruction
    {
        public Instruction()
        {

        }
        
            public void DisplayInstrucstions()
        {
            Console.WriteLine("Hello, Welcome to the Lemonade Stand game.");
            Console.WriteLine("The object of the game is to make as much money as you can.");
            Console.WriteLine("You have control of your recipe, the type of ingredients you use, and the price of your product. \n");

            Console.WriteLine("First step is to decide which recipe you wil be using");
            Console.WriteLine("Then check what the weather will be for the day.  That can determine how much of each ingredients you may need.  The warmer it is is the more you may need.");
            Console.WriteLine("Then decide how many ingredients you will need for the day,  do you need to purchase more or do you have enough.");
            Console.WriteLine("Determine what the price of each cup will be, also according to the weather.  Sometimes if it is cool outside you may need to lower your price of each cup.");
            Console.WriteLine("Now that you have figured out your recipe, ingredients and price; start the game. GOOD LUCK \n");
        }
        
        }
    }

