using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        // naming convention
        public void Ekle(Urun urun) // parantez varsa method çalışıyordur.
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("tebrikler. sepete eklendi : " + urunAdi);
        }



    }
}