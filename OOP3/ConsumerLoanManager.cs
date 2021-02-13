using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ConsumerLoanManager : ILoanBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Consumer loan's payment schedule is calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
