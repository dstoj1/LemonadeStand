using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Customer customer = new Customer();
        public List<Customer> CustomerList;
        public Weather weather = new Weather();
        public Day()
        {
            
        }
        public void GetDay()
        {
            Console.WriteLine("");
        }

    }
}
