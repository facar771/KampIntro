using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer realCustomer = new RealCustomer();
            realCustomer.ID = 5;
            RegalCustomer regalCustomer = new RegalCustomer();
            regalCustomer.ID = 3;

            Customer customer = new RealCustomer();
            Customer customer1 = new RegalCustomer();
        }
    }
}
