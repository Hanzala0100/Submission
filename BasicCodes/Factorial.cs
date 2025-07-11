using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodes
{
    internal class Factorial
    {
        public static void FactorialMethod()
        {
            int number, factorial = 1;
            Console.Write("Enter a number to find factorial: ");
            int.TryParse(Console.ReadLine(), out number);

            for (int i = 2; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"Factorial of {number}: {factorial}");
        }
    }
}
