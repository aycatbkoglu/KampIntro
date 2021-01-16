using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            
        }
    }
}
// int, decimal, float, double, bool = değer tip 
// array, class, interface = referans tip
// stack == sayi1= 10 , sayi2= 30            
// heap == 