using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added : " 
                + customer.Id + " = " + customer.Name + " " + customer.Surname);
        }   
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted : "
                 + customer.Id + " = " + customer.Name + " "+ customer.Surname);
        }
        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer List Id : " + customer.Id);
                Console.WriteLine("Customer List Name : " + customer.Name);
                Console.WriteLine("Customer List Surname : " + customer.Surname);
                Console.WriteLine("------------------------");
            } 
        }
    }
}
