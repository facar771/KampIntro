using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği
            //string KategoriEtiketi = "kategori";
            //Console.WriteLine(KategoriEtiketi);
            //int ogrenciSayisi = 3000;
            //Console.WriteLine(ogrenciSayisi);
            //bool sistemGirisYapmıs = false;
            //Console.WriteLine(sistemGirisYapmıs);

            //if (sistemGirisYapmıs==true)
            //{
            //    Console.WriteLine("kullanıcı ayarları butonu");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş yap butonu");
            //}

            //Console.WriteLine(sistemGirisYapmıs);

            double dolarBugun = 7.9;
            double dolarDun = 7.6;

            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("dolar artmış");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("dolar düşmüş");
            }
            else
            {
                Console.WriteLine("dolar değişmemiş");
            }
        }
    }
}
