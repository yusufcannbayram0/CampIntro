using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class ApplicationManager // BaşvuruManager
    {
        // Method injection 
        public void MakeAnApplication(ICreditManager creditManager, List<ILoggerService> loggerServices) // Başvuru yap
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void DoCreditPreliminaryInformation(List<ICreditManager> credits) // kredi ön bilgilendirmesi yap - ICreditManager türünde liste ver
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }

    }
}
