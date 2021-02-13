using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoanManager : ILoanBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage loan's payment schedule is calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
