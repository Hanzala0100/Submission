
namespace BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Alice", 25, 55, 1.65);
            Console.WriteLine(person1.ToString());

            Console.WriteLine();

            Person person2 = new Person(2, "Bob", 30);
            Console.WriteLine(person2.ToString());
        }
    }
}
