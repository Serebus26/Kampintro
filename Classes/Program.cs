using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.Firstname = "Serhat";
            customer.Lastname = "Akar";
            customer.City = "Eskişehir";

            //Pratik kullanım şekli
            Customer customer2 = new Customer() { Id = 1, Firstname = "Serhat", Lastname = "Akar", City = "Eskişehir" };

            Console.WriteLine(customer2.Id);
        }
    }
}
