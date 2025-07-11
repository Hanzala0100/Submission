using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodes
{
    internal class StringPalindrome
    {
        public static void Palindrome()
        {
            string word;
            Console.Write("Enter a word:");
            word = Console.ReadLine();
            int left = 0, right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                {
                    Console.WriteLine("Word is not palindrome!");
                    return;
                }
                left++;
                right--;
            }
            Console.WriteLine("Word is palindrome!!");
        }
    }
}
