using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                ID = 2,
                CategoryID = 5,
                ProductName = "Kalem",
                UnitPrice = 35,
                UnitsInStock = 500
            };

            ProductManager productManager = new ProductManager();

            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Topla(3, 6);

            int toplamManager = productManager.Topla1(3, 6);
            Console.WriteLine(toplamManager + 6);

            CustomerManager customerManager = new CustomerManager();
            


        }
    }
}
