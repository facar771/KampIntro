using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList2<A>
    {
        A[] isimcik;
        public MyList2()
        {
            isimcik = new A[0];
        }
        public void Add2(A isim)
        {
            A[] tempArray = isimcik;
            isimcik = new A[isimcik.Length + 1];
            for (int i = 0; i < isimcik.Length; i++)
            {
                isimcik[i] = tempArray[i];
            }
            isimcik[isimcik.Length - 1] = isim;
        }
    }
}
