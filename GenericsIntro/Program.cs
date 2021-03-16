using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("ferhat");

            MyList2<string> İsimler2 = new MyList2<string>();
            İsimler2.Add2("ferhat1");

        }
    }
}
