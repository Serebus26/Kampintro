using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "5";
            customer1.Name = "Serhat";
            customer1.LastName = "Akar";
            customer1.TcNumber = "52132134";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "3";
            customer2.CompanyName = "4";
            customer2.TaxNumber = "5123213214";

            Customer customer3 = new CorporateCustomer();
            Customer customer4 = new IndividualCustomer();
            Customer custumer5 = new IndividualCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
