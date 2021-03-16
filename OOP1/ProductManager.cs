using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update (Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public void Topla (int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public int Topla1 (int a, int b)
        {
            return a + b;
        }
    }
}
