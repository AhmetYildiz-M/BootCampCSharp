using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Ahmet"},
                new Student{FirstName = "Suleyman"},
                new Person{FirstName = "Mahmut"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }

    class Person2
    {
        
    }

    class Customer : Person
    {
        public string City { get; set; }

    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
// Bir nesneyi sadece bir kere Inheritance alabiliriz. Ancak Interface'leri birde fazla eklenebilmektedir.