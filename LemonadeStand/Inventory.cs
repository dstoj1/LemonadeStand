using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemon> LemonList = new List<Lemon>();
        public List<Sugar> SugarList = new List<Sugar>();
        public List<Ice> IceList = new List<Ice>();
        public List<Cups> CupsList = new List<Cups>();

        public Inventory()
        {
        }
        public void DisplayInventory()
        {
            Console.WriteLine(LemonList.Count);
            Console.WriteLine(SugarList.Count);
            Console.WriteLine(CupsList.Count);
            Console.WriteLine(IceList.Count);          
        }
        public void AddLemon(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Lemon lemon = new Lemon();
                LemonList.Add(lemon);
            }
        }
        public void AddCups(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Cups cups = new Cups();
                CupsList.Add(cups);
            }
        }
        public void AddSugar(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Sugar sugar = new Sugar();
                SugarList.Add(sugar);
            }
        }
        public void AddIce(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Ice ice = new Ice();
                IceList.Add(ice);
            }
        }
        public void RemoveIce(double Number)
        {
            for(double i = 0; i < Number; i++)
            {
                Ice ice = new Ice();
                IceList.RemoveAt(0);
            }
        }
        public void RemoveSugar(double Number)
        {
            for(double i = 0; i < Number; i++)
            {
                Sugar sugar = new Sugar();
                SugarList.RemoveAt(0);
            }
        }
        public void RemoveLemon(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Lemon lemon = new Lemon();
                LemonList.RemoveAt(0);
            }
        }
        public void RemoveCups(double Number)
        {
            for(double i = 0; i < Number; i++)
            {
                Cups cups = new Cups();
                CupsList.RemoveAt(0);
            }
        }
    }
}
