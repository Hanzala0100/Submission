using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodes
{
    internal class FibonacciSeries
    {
        public static void Fibonacci()
        {
            int number1 = 0, number2 = 1, sum = 0, numberOfElements;
            Console.Write("Enter number of elements: ");
            numberOfElements = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine(number1);
                sum = number1 + number2;
                number1 = number2;
                number2 = sum;
            }
        }
    }
}
