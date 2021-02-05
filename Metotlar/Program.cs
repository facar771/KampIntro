using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            Urun urun2 = new Urun();
            Urun urun3 = new Urun();

            urun1.Adi = "Domates";
            urun1.Fiyati = 5;
            urun1.Id = 101;
            urun1.Aciklama = "Taze";
            urun1.Yas = 21;

            urun2.Adi = "Çilek";
            urun2.Fiyati = 4;
            urun2.Id = 102;
            urun2.Aciklama = "Taze";

            urun3.Adi = "Karpuz";
            urun3.Fiyati = 6;
            urun3.Id = 103;
            urun3.Aciklama = "Çürük";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var Urunler in urunler)
            {
                Console.WriteLine(Urunler.Adi);
                Console.WriteLine(Urunler.Fiyati);
                Console.WriteLine(Urunler.Id);
                Console.WriteLine(Urunler.Aciklama);
            }
            Console.WriteLine("----------Metotlar----------");

            SepetManager sepetmanager = new SepetManager();

            sepetmanager.Ekle(urun1);

            sepetmanager.Ekle2(urun1);
        }
    }
}
