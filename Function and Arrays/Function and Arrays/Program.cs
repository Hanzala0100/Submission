namespace Function_and_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] StudentFees = new double[5];
            PayFees(StudentFees);
            DisplayFees(StudentFees);
        }

        public static void PayFees(double[] students)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter Fees for Student {i+1}: ");
                int fees = int.Parse(Console.ReadLine());
                if (fees < 5000 || fees > 10000)
                {
                    while (fees < 5000 || fees > 10000)
                    {
                        Console.WriteLine("Fees Should be between 5000 to 10000 Rs");
                        Console.Write($"Enter Fees for Student {i+1}: ");
                        fees = int.Parse(Console.ReadLine());
                    }
                    students[i] = fees;
                }
                else if (fees > 7000)
                {
                    students[i] = fees * 0.95;
                }
                else
                {
                    students[i] = fees;
                }
            }
        }

        public static void DisplayFees(double[] students)
        {
            Console.WriteLine("Fees for Students:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: {students[i]} Rs");
            }
        }
    }
}
