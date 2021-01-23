using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager // interface: şablon görevi görüyor.
        // okunurluğu arttırmak için "I" ile başlatılır. interfae olduğu anlaşılır.
    {
        void Calculate();

        void DoSomething();
        
    }
}
// *interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.