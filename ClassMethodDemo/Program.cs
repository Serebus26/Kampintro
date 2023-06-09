using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Serhat";
            customer1.Surname = "AKAR";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Samet";
            customer2.Surname = "Karadeniz";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            Console.WriteLine("----------------------");
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            Console.WriteLine("----------------------");

            Customer[] customers = new Customer[] { customer1, customer2 };
            customerManager.List(customers);
        }
    }
}
