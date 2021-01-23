using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AplicationManager //başvuru
    {
        public void DoAplication(ICreditManager creditManager,ILoggerServices loggerServices) 
        {
            // başvuran bilgilerini değerlendirme
            //....


            creditManager.Calculate();

           
            loggerServices.Log();
        }
        public void MakeCreditPreliminaryInformation(List<ICreditManager> credits) // başvuruyu krediden bağımsız hale getirdik.
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
            

            
        }

    }
}