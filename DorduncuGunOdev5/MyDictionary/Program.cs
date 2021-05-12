using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> words =new MyDictionary<string> ();

            words.Add("Ferhat");

            Console.WriteLine(words.Length);

            words.Add("Sumeyye");

            Console.WriteLine(words.Length);
        }
    }
}
