using System;

namespace CSharpMosh
{
    public class Calculator
    {
        // params allows you to pass an array of values without initializing them in Main
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
