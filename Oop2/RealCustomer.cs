using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    class RealCustomer : Customer
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string TcNum { get; set; }
    }
}



// bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsa, bir terslik varsa orada soyutlama hatası vardır.