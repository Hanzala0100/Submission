namespace BasicStatsCommaindLineApp
{

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide numbers as command-line arguments.");
                return;
            }

            int[] numbers;
            try
            {
                numbers = args.Select(int.Parse).ToArray();
            }
            catch (FormatException)
            {
                Console.WriteLine("All inputs must be valid integers.");
                return;
            }

            int count = numbers.Length;
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();
            int min = numbers.Min();

            Console.WriteLine("Count: " + count);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Minimum: " + min);
        }
    }

}