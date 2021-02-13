using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TradesmanLoanManager : ILoanBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Tradesman loan's payment schedule is calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
