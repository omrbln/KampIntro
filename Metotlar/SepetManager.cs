using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention -- isimlendirme kuralı
        //syntax
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + product.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urunAdi);
        }
    }
}
