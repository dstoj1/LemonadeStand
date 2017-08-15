﻿using System;
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
        Instruction instructions;
        


        public Game()
        {
           player = new Player();
           day = new Day();
           store = new Store();
           weather = new Weather();
           instructions = new Instruction();
        }
       
        public void RunGame()
        {
           instructions.DisplayInstrucstions();
           weather.GetWeather();
           weather.MakeWeather();
           store.GetSupplies(player);
           player.inventory.DisplayInventory();
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
