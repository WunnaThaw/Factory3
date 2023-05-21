using CustomerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{

    class Program
    {
        static void Main(string[] args)
        {
            //Client Code
            CustomerFactory c = new GoldCustomerFactory();// Or new SilverCustomerFactory();
            ICustomer objCust = c.GetCustomer();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
