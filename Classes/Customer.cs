using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //public string FirstName; bu sekilde de yazilabilir. 

        //Property


        //Asagidaki uygulama encapsulation uygulamasidir. 
        //private string _firstName;
        //public string FirstName    
        //{ 
        //    get { return "Mrs." + _firstName; }
        //    set { _firstName = value; } 
        //}
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
