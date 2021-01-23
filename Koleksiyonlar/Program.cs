
using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args) //dizileri gevşetemiyoruz.
        {
            //string[] isimler = new string[] { "engin", "murat", "kerem", "halil" };
            //console.writeline(isimler[0]);
            //console.writeline(isimler[1]);
            //console.writeline(isimler[2]);
            //console.writeline(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "ilker";
            //console.writeline(isimler[4]);
            //console.writeline(isimler[0]);

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" }; //değerleri kaybetmemiz engeller 
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

           
            


        }
    }
}