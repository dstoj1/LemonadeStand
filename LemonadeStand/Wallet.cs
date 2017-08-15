using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Wallet
    {
        public double money = 25.00;
         
        public Wallet()
        {

        }
        public bool RemoveMoney(double total)
        {
            if (total  < money)
            {
                money -= total;
                Console.WriteLine(money);
                return true;
            }
            return false;         
         }
      }
}
