using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Serhat";

            Console.WriteLine("FirtsName : " + person);


        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer
    {
        public int CreditCardNumber { get; set; }
    }
    class Employee
    {
        public int EmployeeID { get; set; }
    }
}
