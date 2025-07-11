using System;

namespace EnumPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DAYS OF WEEK
            DaysOfWeek.DaysOfWeekMethod();

            // TRAFFIC LIGHT SIGNAL
            Console.Write("Signal: ");
            if (Enum.TryParse(Console.ReadLine(), true, out TrafficLight.Lights inputLight))
            {
                TrafficLight.ShowTrafficSignal(inputLight);
            }
            else
            {
                Console.WriteLine("Invalid signal input.");
            }
        }
    }
}
