using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // metinsel ifadeler çift tırnak
            // satır sonuna noktalı virgül
            // kategoriEtiketi = değer tutucu, alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faziOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }


            if (sistemeGirisYapmisMi== true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
           

            Console.WriteLine(kategoriEtiketi);
          

            //List<Product> products;
        }
    }
}
