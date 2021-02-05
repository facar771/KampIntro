using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs a = new Kurs();
            Kurs b = new Kurs();
            Kurs c = new Kurs();

            a.Isim = "Ferhat";
            a.Sehir = "Kastamonu";
            a.Yas = 21;

            b.Isim = "qewqweqwe";
            b.Sehir = "zcxzxczcx";
            b.Yas = 12;

            c.Isim = "asdasdas";
            c.Sehir = "vvbnvbnnbv";
            c.Yas = 212;

            Console.WriteLine(a.Isim);

            Kurs[] Kisiler = new Kurs[] {a,b,c};

            foreach (var d in Kisiler)
            {
                Console.WriteLine(d.Isim);
                Console.WriteLine(d.Sehir);
                Console.WriteLine(d.Yas);
                Console.WriteLine("----------------");
            }

        }
    }

    class Kurs
    {
        public string Isim { get; set; }
        public string Sehir { get; set; }
        public int Yas { get; set; }
    }
}
