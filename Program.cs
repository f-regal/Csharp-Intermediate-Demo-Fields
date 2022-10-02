using System;

namespace Csharp_Intermediate_Demo_Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();
            Console.WriteLine(customer.Orders.Count);
        }
    }
}
