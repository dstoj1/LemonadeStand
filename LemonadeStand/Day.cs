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
        //method for list of customers
        //For every customer that purchases decrease from inventory
        //add money to the total tally for the day.
        //RunDay():
        public void GetCustomer()
        {
            for (int i = 0; i < 150; i++)
            {
                if (i < 50)
                {
                    Console.WriteLine(" ");
                }
                else if (i > 50 && i < 100)
                {
                    Console.WriteLine(" ");
                }
                else if (i > 100 && i < 150)
                {
                    Console.WriteLine(" ");
                }
            }
        }  
        public void MakeCustomer()
        {
            int  NumberOfCustomers = 150;
            for (int i = 0; i < NumberOfCustomers; i++)
            {
                Customer customer = new Customer();

            }
        }
    }
}
