using System;
using System.Collections.Generic;
using System.Text;

namespace UcuncuGunOdev3
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " kisisi eklendi.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " kisisi silindi.");
        }
        public void Listing(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " kisisi listelendi.");
        }
    }
}
