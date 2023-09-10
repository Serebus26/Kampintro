using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class ApplicationManager
    {
                                                //Method injection
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerService)
        {
            creditManager.Calculate();

            foreach (var loggerServices in loggerService)
            {
                loggerServices.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }

}
