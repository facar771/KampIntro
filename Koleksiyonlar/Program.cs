using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "ferhat", "acar" };

            //Console.WriteLine(isimler[0]);
            //isimler = new string[2];
            //isimler[2] = "Sümeyye";

            List<string> isimler1 = new List<string> { "ferhat", "acar" };
            
            //Console.WriteLine(isimler1[0]);

            isimler1.Add("Sümeyye");

            Console.WriteLine(isimler1[0]);
            Console.WriteLine(isimler1[2]);
        }
    }
}
