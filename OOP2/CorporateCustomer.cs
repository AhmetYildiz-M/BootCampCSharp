using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CorporateCustomer:Customer //Inheritance miras alma anlamina gelmektedir.
    {
        
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
