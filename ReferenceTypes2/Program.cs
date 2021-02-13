using System;

namespace ReferenceTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, folat, enum, boolean value types

            //int number1 = 10;
            //int number2 = 20;
            //number1 = number2;
            //number2 = 100;

            //Console.WriteLine("Number1 : " + number1);

            ////array, class, interface... reference types

            //int[] numbers1 = new int[] { 1, 2, 3 };
            //int[] numbers2 = new int[] { 10, 20, 30 };

            //numbers1 = numbers2;

            //numbers2[0] = 1000;
            //Console.WriteLine("Numbers1[0] = " + numbers1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Ahmet";

            person2 = person1;

            person1.FirstName = "Derin";

         

            //Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Mahmut";
            customer.CreditCardNumber = "45115544455445";
            


            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;
            customer.FirstName = "Suleyman";

            //Console.WriteLine(((Customer)person3).CreditCardNumber); //Boxing uygulamasi yapilmistir. 
            //Yani person bu sekilde Customer deger olan creditCardNumber degerini almistir.

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

    class Customer:Person // Inheritance yapilmistir.
    {
        public string CreditCardNumber { get; set; }


    }

    class Employee:Person //Person degeri inheritance (Miras birakmak) olmaktadir. Person degerleri alabilir. Person base sinif olmaktadir. BaseClass
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
