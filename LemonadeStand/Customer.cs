using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        int randomCustomer;
        public Customer()
        {

        }


        public void MakeCustomer()
        {
            Random random = new Random();
            randomCustomer = random.Next(0, 150);

        }
    }     
}
