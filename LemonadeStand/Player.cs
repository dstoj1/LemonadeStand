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
        public double money;

        public Player()
        {

        }
    }
}
