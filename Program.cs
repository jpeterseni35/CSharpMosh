using System;

namespace CSharpMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Jake");
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);
        }
    }
}
