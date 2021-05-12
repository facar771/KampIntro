using System;

namespace UcuncuGunOdev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.ID = 1;
            customer.FirstName = "Ferhat";
            customer.LastName = "ACAR";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.Listing(customer);
        }
    }
}
