using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.CustomerId = 1;
            customer1.CustomerNum = "123456";
            customer1.Name = "Ayça";
            customer1.SurName = "Tabakoğlu";
            customer1.TcNum = "123789";

            LegalCustomer customer2 = new LegalCustomer();
            customer2.CustomerId = 2;
            customer2.CustomerNum = "12236548";
            customer2.CompanyName = "Kodlamaio";
            customer2.TaxNum = "123789789654";

            // Gerçek - Tüzel Müşteri
            //SOLID

            Customer customer3 = new RealCustomer(); // new = bellekteki referans no'su
            Customer customer4 = new LegalCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);



            


        }
    }
}
