using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProgram
{
    internal class WaterbillGenerate
    {
        public static void CalculateBill()
        {
            Console.WriteLine("Enter the number of units consumed:");
            string units = Console.ReadLine();

            int meterCharge = 75, charge = 0, totalWaterBill = 0;
            int unitsConsumed = int.Parse(units);
            if (unitsConsumed <= 100)
            {
                charge = unitsConsumed * 5;
            }
            else
            {
                if (unitsConsumed <= 250)
                {
                    charge = unitsConsumed * 10;
                }
                else
                {
                    charge = unitsConsumed * 20;
                }
            }
            totalWaterBill = charge + meterCharge;
            Console.WriteLine("The total water bill:" + totalWaterBill);
        }
    }
}
