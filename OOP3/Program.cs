using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager.Calculate();

            ICreditManager transportCreditManager = new TransportCreditManager();
            //transportCreditManager.Calculate();

            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            //mortgageCreditManager.Calculate();

            ILoggerServices databaseLoggerServices = new DatabaseLoggerServices();
            ILoggerServices fileLoggerServices = new FileLoggerServices();

            AplicationManager aplicationManager = new AplicationManager();
            aplicationManager.DoAplication( new ArtisanCreditManager(), new SmsLoggerServices());

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager, transportCreditManager};
            //aplicationManager.MakeCreditPreliminaryInformation(credits);


        }
    }
}
