using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsumerLoanManager consumerLoanManager = new ConsumerLoanManager();
            //consumerLoanManager.Calculate();

            //VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
            //vehicleLoanManager.Calculate();

            //MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            //mortgageLoanManager.Calculate();


            //Interfaceler diger classlardaki inherite olabilir. Cunku tum kredi hesaplama yontemlerinde miras almistir.

            //ILoanBaseManager consumerLoanManager1 = new ConsumerLoanManager();
            //consumerLoanManager1.Calculate();

            //ILoanBaseManager vehicleLoanManager1 = new VehicleLoanManager();
            //vehicleLoanManager1.Calculate();

            //ILoanBaseManager mortgageLoanManager1 = new MortgageLoanManager();
            //mortgageLoanManager1.Calculate();



            ILoanBaseManager consumerLoanManager2 = new ConsumerLoanManager();
            ILoanBaseManager vehicleLoanManager2 = new VehicleLoanManager();
            ILoanBaseManager mortgageLoanManager2 = new MortgageLoanManager();
            ILoanBaseManager tradesmanLoanManager2 = new TradesmanLoanManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> services = new List<ILoggerService>(){ databaseLoggerService, smsLoggerService };

            CreditApplicationManager creditApplicationManager = new CreditApplicationManager();
            //creditApplicationManager.CreditApplication(consumerLoanManager2, databaseLoggerService);

            creditApplicationManager.CreditApplication(tradesmanLoanManager2, services);

            List<ILoanBaseManager> loans = new List<ILoanBaseManager>() {consumerLoanManager2, vehicleLoanManager2,mortgageLoanManager2};
            //creditApplicationManager.ProvideCreditPreNotification(loans);

            //Interfaceleri birbirinin alternatifi olan ama kod icerikleri birbirinden farkli olan durumlar icin kullaniriz.
            //Bu yaptigimiz ornekte tum krediler hesaplama ortak bir nokta vardir. Ancak kodlari farkli kurallari vardir.
            //Kredinin turlerine hesaplama turleri degiskenlik gosterir.


        }
    }
}
