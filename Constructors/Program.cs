using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(5, "Serhat", "Akar", "Eskişehir");
            Console.WriteLine(customer.Id + customer.Firstname + customer.Lastname + customer.City);
        }
    }

    class Customer
    {
        public Customer(int id, string firstname, string lastname, string city)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            City = city;
        }


        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
    }
}
