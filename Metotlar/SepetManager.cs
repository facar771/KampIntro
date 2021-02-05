using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
         public void Ekle(Urun urun)
         {
            Console.WriteLine("Ürün eklendi:" + urun.Adi);
         }
         public void Ekle2(Urun urun)
         {
            Console.WriteLine("merhaba" + urun.Yas);
         }
    }
}
