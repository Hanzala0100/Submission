namespace Loops_and_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For Loop Example
            Console.WriteLine("For Loop Example");

            ForLoop forLoop = new ForLoop();
            Console.WriteLine("For Loop Output:");
            forLoop.PrintNumbers();

            // While Loop Example
            Console.WriteLine("\n While Loop Example ");
            WhileLoop whileLoop = new WhileLoop();
            Console.WriteLine("While Loop Output:");
            whileLoop.PrintNumbers();

            // Int Array Example
            Console.WriteLine("\n Int Array Example ");
            Int_Array intArray = new Int_Array();
            Console.WriteLine("Int Array Output:");
            intArray.PrintNumbers();
            Console.WriteLine($"Sum of Numbers:  {intArray.SumNumbers()}");

            Console.WriteLine($"Max Number:  {intArray.MaxNumber()}");

            Console.WriteLine($"Min Number:  {intArray.MinNumber()}");

            Console.WriteLine($"Average Number:  {intArray.AverageNumber()}");

            // String Array Example

            Console.WriteLine("\n String Array Example ");

            String_Array stringArray = new String_Array();
            Console.WriteLine("String Array Output:");

            stringArray.PrintNames();

            string concatenatedNames = stringArray.ConcatenateNames();

            Console.WriteLine($"\nConcatenated Names: {concatenatedNames}");

        }
    }
}
