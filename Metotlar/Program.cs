using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product urun3 = new Product();
            urun3.Adi = "Armut";
            urun3.Fiyati = 12;
            urun3.Aciklama = "Yeşil armut";

            Product[] urunler = new Product[] { urun1, urun2, urun3 };

            //typr-safe -- tip güvenli
            foreach (Product product in urunler)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("--------------------METOTLAR--------------------");

            //instance -- class örneği oluşturmak
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 15, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80, 8);


        }
    }
}


//Don't repeat yourself - DRY - Clean Code (Temiz kod yazma) - Best Practice (Doğru, en iyi, uygulama teknikleri)
