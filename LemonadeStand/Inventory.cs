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
        
    }
}
