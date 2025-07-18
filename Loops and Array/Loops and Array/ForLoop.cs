using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_and_Array
{
    internal class ForLoop
    {
        int[] numbers = { 11, 52, 33, 24, 65 };
        public void PrintNumbers()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
