using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        // O -> Open Close Princible - sisteme yeni bir özellik eklendiğinde mevcut kodlar bozulmaz
        static void Main(string[] args)
        {
            ICreditManager requirementCreditManager = new RequirementCreditManager();       
            ICreditManager vehicleCreditManager = new VehicleCreditManager();      
            ICreditManager residenceCreditManager = new ResidenceCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            List<ILoggerService> loggerServices = new List<ILoggerService>() { databaseLoggerService,smsLoggerService};

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(new ArtisanCreditManager(), loggerServices); // bir tane kredi türü hesaplandı


            List<ICreditManager> credits = new List<ICreditManager>() { requirementCreditManager,vehicleCreditManager}; // birden çok kredi türü hesaplamak için liste kullanıldı
            //applicationManager.DoCreditPreliminaryInformation(credits);
        }
    }
}
