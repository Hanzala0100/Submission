using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProgram
{
    internal class TreasureHunt
    {
        public static void TreasureHuntMethod()
        {
            Console.WriteLine("Welcome to Treasure Island.");
            Console.WriteLine("Your mission is to find the treasure.");
            Direction();
        }
        static void Direction()
        {
            Console.WriteLine("Do you want to go right or left??");
            string? direction = Console.ReadLine()?.ToLower();
            if (direction == "right" || direction != "left")
            {
                Console.WriteLine("Ooppss.......You fall into a hole. Game Over!!");
            }
            else if (direction == "left")
            {
                Swim();
            }
            Console.ReadKey();
        }
        static void Swim()
        {
            Console.WriteLine("Do you want to swim or wait??");
            string? isSwim = Console.ReadLine()?.ToLower();
            if (isSwim == "swim" || isSwim != "wait")
            {
                Console.WriteLine("Ooppss.......You are attacked by trout. Game Over!!");
            }
            else
            {
                ChooseDoor();
            }
            Console.ReadKey();
        }
        static void ChooseDoor()
        {
            Console.WriteLine("Choose which door you want to choose (red/blue/yellow)?");
            string? doorColor = Console.ReadLine()?.ToLower();
            if (doorColor == "red")
            {
                Console.WriteLine("Burned by fire. Game Over");
            }
            else if (doorColor == "blue")
            {
                Console.WriteLine("Eaten by beasts. Game Over");
            }
            else if (doorColor == "yellow")
            {
                Console.WriteLine("Congrats!! You Win!");
            }
            else
            {
                Console.WriteLine("Game Over");
            }
            Console.ReadKey();
        }
    }
}
