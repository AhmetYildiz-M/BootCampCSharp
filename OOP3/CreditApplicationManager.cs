using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CreditApplicationManager
    {
        public void CreditApplication(ILoanBaseManager loanBaseManager, List<ILoggerService> loggerServices) //Kredi turlerinden bagimsiz hale gelmistir.
        {

            //Basvuran bilgilerini degerlendirme

            //Asagida sadece Mortgage kredisi icin hesaplama yapar.
            //MortgageLoanManager mortgageLoanManager2 = new MortgageLoanManager();
            //mortgageLoanManager2.Calculate();

            //Interface kredi basvurusu eklendikten sonra her turlu kredi hesaplamasi yapilabilir.
            //Method injection
            loanBaseManager.Calculate();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
            

        }

        public void ProvideCreditPreNotification(List<ILoanBaseManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();

            }
        }



    }
}
