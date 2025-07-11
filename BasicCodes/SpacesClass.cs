using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodes
{
    internal class SpacesClass
    {
        public static void SpaceInSentence()
        {
            int spacesCount = 0;
            string sentence;
            Console.Write("Enter the sentence: ");
            sentence = Console.ReadLine();

            foreach (char letter in sentence)
            {
                if (letter == ' ')
                {
                    spacesCount++;
                }
            }
            Console.WriteLine("The number of spaces in a sentence is: " + spacesCount);
        }
    }
}
