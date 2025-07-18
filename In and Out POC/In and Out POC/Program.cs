namespace In_and_Out_POC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 10;
            int addition, multiply;

            Program.Calculate(number1, number2, out addition, out multiply);
            Console.WriteLine("Addition:{0}\nMultiplication:{1}", addition, multiply);

            Program.ShowSquare(in number1);

            Console.Write("\nEnter a number to parse:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int parsedNumber))
            {
                Console.WriteLine("Successfully parsed number: {0}", parsedNumber);
            }
            else
            {
                Console.WriteLine("Invalid number format.");
            }

            Program.DisplayNumbers(1, 2, 3, 4, 5);

            Console.WriteLine("\nNumbers: {0}, {1}, {2}", 10, 20, 30);
        }

        static void Calculate(int num1, int num2, out int add, out int multi)
        {
            add = num1 + num2;
            multi = num1 * num2;
        }

        static void ShowSquare(in int number)
        {
            Console.WriteLine("Square of {0} is {1}", number, number * number);
        }

        static void DisplayNumbers(params int[] numbers)
        {
            Console.WriteLine("\nDisplaying numbers using params:");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
