using System;

namespace CSharpMosh
{
    class Program
    {
        static void Main(string[] args)
        {

            var customer = new Customer
            {
                Id = 2,
                Name = "Jim"
            };
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);

        }

        static void UseParams()
        {
            var calculator = new Calculator();
            System.Console.WriteLine(calculator.Add(1, 2));
            System.Console.WriteLine(calculator.Add(1, 2, 3));
            System.Console.WriteLine(calculator.Add(1, 2, 3, 4));
            System.Console.WriteLine(calculator.Add(5, 444, 5332));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (System.Exception)
            {

                System.Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}
