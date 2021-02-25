using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
                customerManager.Save(new Customer{DateOfBirth = new DateTime(1986,1,14), FirstName = "Ahmet", 
                    Lastname = "Yıldız", NationalityId = "14498910994"});
                Console.ReadLine();


        }
        
    }
}
