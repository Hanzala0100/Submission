using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPrograms
{
    internal class DaysOfWeek
    {
        enum Days { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        public static void DaysOfWeekMethod()
        {
            int number;
            Console.Write("Enter a number (1-7): ");
            int.TryParse(Console.ReadLine(), out number);
            Days day = (Days)number;
            Console.WriteLine("Day is: " + day);
        }
    }
}
