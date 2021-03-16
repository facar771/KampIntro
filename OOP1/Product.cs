using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int ID { get; set; } // Ürün Id si
        public int CategoryID { get; set; } // Hangi kategori
        public string ProductName { get; set; } // Ürün ismi
        public double UnitPrice { get; set; } // Ürünün birim fiyatı
        public int UnitsInStock { get; set; } // Stok adedi
    }
}
