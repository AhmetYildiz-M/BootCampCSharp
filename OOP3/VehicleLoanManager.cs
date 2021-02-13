using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleLoanManager : ILoanBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle loan's payment schedule is calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
