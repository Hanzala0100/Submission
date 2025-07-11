using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodes
{
    internal class Armstrong
    {
        public static void ArmstrongMethod()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int original, digit = 0, sum = 0, cube = 0;
            original = number;
            while (number > 0)
            {
                digit = number % 10;
                cube = digit * digit * digit;
                number = number / 10;
                sum += cube;
            }
            if (sum == original)
            {
                Console.WriteLine("It is an armstrong");
            }
            else
            {
                Console.WriteLine("It is not an armstrong");
            }
        }
    }
}
