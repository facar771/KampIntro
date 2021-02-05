using System;

namespace Methodlar
{
    class Program
    {

        static void Main(string[] args)
        {
            Urun meyve1 = new Urun();
            meyve1.Adi = "Elma";
            Urun meyve2 = new Urun();
            meyve2.Adi = "dfssdfa";
            Urun meyve3 = new Urun();
            meyve3.Adi = "sdfsdfa";
            Urun meyve4 = new Urun();
            meyve4.Adi = "Edfssdfsma";

            Urun[] dizi = new Urun[] { meyve1, meyve2, meyve3, meyve4 };

            foreach (Urun diziler in dizi)
            {
                Console.WriteLine(diziler.Adi);
            }


        }
    }
}
