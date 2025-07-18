using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_and_Array
{
    internal class WhileLoop
    {
        int[] numbers = { 11, 32, 53, 14, 95 };
        public void PrintNumbers()
        {
            int i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }
        }
    }
}
