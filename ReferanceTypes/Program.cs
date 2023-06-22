using System;


namespace ReferanceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Id = 1;
            person.FirstName = "Serhat";
            person.LastName = "AKAR";

            Customer customer = new Customer();
            customer.FirstName = "Samet";
            customer.LastName = "Karadeniz";
            customer.CreditCardNumber = 99999;

            Person person1 = customer;

            Console.WriteLine(((Customer)person1).CreditCardNumber);

            Employee employee = new Employee();
            employee.FirstName = "İlker";

            PersonManager personManager = new PersonManager();
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
            Console.WriteLine("Id : " + person.Id + " : " + "FirsName : "
                 + person.FirstName + "  " +
               "LastName : " + person.LastName);

        }
    }
}
