using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProgram
{
    internal class NumberGuesser
    {
        public static void GuessNumber()
        {
            string playAgain;
            do
            {
                Random rand = new Random();
                int randomNumber = rand.Next(1, 100);
                int guessedNumber = 0, turn = 0;

                Console.WriteLine("Random number is generated between 1-100!!");

                do
                {
                    turn++;
                    Console.Write("Guess a Number? ");
                    if (!int.TryParse(Console.ReadLine(), out guessedNumber))
                    {
                        Console.WriteLine("Please enter a valid number.");
                        continue;
                    }
                    if (guessedNumber < 1 && guessedNumber > 101)
                    {
                        Console.WriteLine("Please enter a number between 1-100.");
                        continue;
                    }

                    if (guessedNumber < randomNumber)
                    {
                        Console.WriteLine("Sorry too low");
                    }
                    else if (guessedNumber > randomNumber)
                    {
                        Console.WriteLine("Sorry too high");
                    }
                    else
                    {
                        Console.WriteLine("Congrats!! You guessed the correct number.");
                        Console.WriteLine($"In attempt: {turn}");
                    }
                }
                while (guessedNumber != randomNumber);

                Console.Write("Do you want to play the game again? (yes/no):");
                playAgain = Console.ReadLine().ToLower();
            } while (playAgain == "yes");
        }
    }
}
