using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonelLoanManager personelLoanManager = new PersonelLoanManager();
            AutoLoanManager autoLoanManager = new AutoLoanManager();
            MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(personelLoanManager);
            applicationManager.Apply(autoLoanManager);
            applicationManager.Apply(mortgageLoanManager);

            List<ICreditManager> credits = new List<ICreditManager>() { personelLoanManager, autoLoanManager, mortgageLoanManager };
            applicationManager.KrediOnBilgilendirmesiYap(credits);
            

        }
    }
}
