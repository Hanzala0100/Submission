using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodes
{
    internal class ReverseNumber
    {
        public static void Reverse()
        {
            int number, digit, reverseNumber = 0;
            Console.Write("Enter a number:");
            number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                digit = number % 10;
                reverseNumber = reverseNumber * 10 + digit;
                number = number / 10;
            }
            Console.WriteLine($"Reverse of given number: {reverseNumber}");
        }
    }
}
