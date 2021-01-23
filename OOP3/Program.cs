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

            //Yukarıdaki ve aşağıdaki ifadeler birebir aynı şeyi ifade ediyor

            //ILoanManager consumerLoanManager = new ConsumerLoanManager();
            //consumerLoanManager.Calculate();

            //ILoanManager vehicleLoanManager = new VehicleLoanManager();
            //vehicleLoanManager.Calculate();

            //ILoanManager mortgageLoanManager = new MortgageLoanManager();
            //mortgageLoanManager.Calculate();



            ILoanManager consumerLoanManager = new ConsumerLoanManager();
            ILoanManager vehicleLoanManager = new VehicleLoanManager();
            ILoanManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            AppealManager appealManager = new AppealManager();
            appealManager.MakeAnApplication(new TradesmanLoanManager(), loggers);

            List<ILoanManager> loans = new List<ILoanManager>() {consumerLoanManager, vehicleLoanManager, mortgageLoanManager };

            //appealManager.MakeLoanPrenotification(loans);

        }
    }
    
}
