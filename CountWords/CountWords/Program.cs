namespace CountWords
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a sentence:");

            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;

            Console.WriteLine("Total words: " + wordCount);
        }
    }

}
