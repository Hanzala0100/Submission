using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodes
{
    internal class NumberPalindrome
    {
        public static void PalindromeNumber()
        {
            int number, digit, reverseNumber = 0, original;
            Console.Write("Enter a number:");
            number = int.Parse(Console.ReadLine());
            original = number;
            while (number > 0)
            {
                digit = number % 10;
                reverseNumber = reverseNumber * 10 + digit;
                number = number / 10;
            }
            if (original == reverseNumber)
            {
                Console.WriteLine("It is Palindrome: " + original);
            }

            else
            {
                Console.WriteLine("It is not Palindrome");
            }
        }
    }
}
