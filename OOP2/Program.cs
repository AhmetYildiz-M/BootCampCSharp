using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RetailCustomer retailCustomer1 = new RetailCustomer();
            retailCustomer1.Id = 1;
            retailCustomer1.CustomerNumber = "15745545";
            retailCustomer1.FirstName = "Ahmet";
            retailCustomer1.LastName = "Yildiz";
            retailCustomer1.IdentifyNumber = "45745454412";

            //Kodlamai io

            CorporateCustomer corporateCustomer1 = new CorporateCustomer();
            corporateCustomer1.Id = 2;
            corporateCustomer1.CustomerNumber = "787877";
            corporateCustomer1.CompanyName = "Kodlama.io";
            corporateCustomer1.TaxNumber = "12145545521";

            //Gercek Musteri - Tuzel Musteri
            //SOLID

            Customer customer3 = new RetailCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(corporateCustomer1);
            customerManager.Add(retailCustomer1);



        }
    }
}
