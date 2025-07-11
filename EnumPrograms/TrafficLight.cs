using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPrograms
{
    public class TrafficLight
    {
        public enum Lights { Red, Yellow, Green }
        public static void ShowTrafficSignal(Lights light)
        {
            switch (light)
            {
                case Lights.Red:
                    Console.WriteLine("Stop");
                    break;
                case Lights.Yellow:
                    Console.WriteLine("Get Ready");
                    break;
                case Lights.Green:
                    Console.WriteLine("Go");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
