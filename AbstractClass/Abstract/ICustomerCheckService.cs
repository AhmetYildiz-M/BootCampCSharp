using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
       public bool CheckIfRealPerson(Customer customer);
       
    }
}
