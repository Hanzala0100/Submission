using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_and_Array
{
    internal class Int_Array
    {
        int[] numbers = { 11, 42, 33, 14, 75 };
        public void PrintNumbers()
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public int SumNumbers()
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int MaxNumber()
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }
        public int MinNumber()
        {
            int min = numbers[0];
            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
        public double AverageNumber()
        {
            int sum = SumNumbers();
            return (double)sum / numbers.Length;
        }
    }
}
