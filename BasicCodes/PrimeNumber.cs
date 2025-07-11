using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodes
{
    internal class PrimeNumber
    {
        public static void PrimeNumberMethod()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("It is not a prime number");
                    return;
                }
            }
            Console.WriteLine("It is a prime number");
        }
    }
}
