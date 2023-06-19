using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Id = 1;
            person.FirstName = "Serhat";
            person.LastName = "Akar";



            // Console.WriteLine("Person ID : " + person.Id +
            //    " FirstName : " + person.FirstName + " LastName : " + person.LastName);

            Customer customer = new Customer();
            customer.CreditCardNumber = 999999;
            customer.LastName = "Akar";


            // Console.WriteLine("Card Number : " + customer.CreditCardNumber);

            Employee employee = new Employee();
            employee.EmployeeNumber = 22;
            employee.FirstName = "Serhat";


            // Console.WriteLine("EmployeeNumber : " + employee.EmployeeNumber);


            // Console.WriteLine(((Customer)person).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            personManager.Add(customer);

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public int CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName + person.LastName);
            
        }
    }
}
