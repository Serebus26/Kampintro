using System.Collections.Generic;

namespace OOP3
{
     class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personelLoanManager = new PersonelLoanManager();
            ICreditManager autoLoanManager = new AutoLoanManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService>()
            { new DataBaseLoggerService(), new FileLoggerService() };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(personelLoanManager, loggerServices);
            applicationManager.Apply(autoLoanManager, loggerServices);
            applicationManager.Apply(mortgageLoanManager, loggerServices);

            List<ICreditManager> credits = new List<ICreditManager>() { personelLoanManager, autoLoanManager, mortgageLoanManager };
            applicationManager.KrediOnBilgilendirmesiYap(credits);
        }
    }
}
