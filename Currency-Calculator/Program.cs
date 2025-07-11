namespace CurrencyCalculator
{
    public class CurrencyCalculator
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the Amount (should not exceed 50000 and must be multiple of 100): ");
                bool isValid = int.TryParse(Console.ReadLine(), out int amount);
                if (amount > 50000)
                {
                    Console.WriteLine("Amount is exceeding 50000");
                    continue;
                }
                if (amount % 100 != 0)
                {
                    Console.WriteLine("Amount is not a multiple of 100");
                    continue;
                }
                CountCurrency(amount);
                Console.ReadKey();
                break;
            }
        }
        static void CountCurrency(int amount)
        {
            int[] denominations = { 2000, 500, 200, 100 };
            foreach (int note in denominations)
            {
                int count = 0;
                switch (note)
                {
                    case 2000:
                        count = amount / note;
                        amount %= note;
                        break;
                    case 500:
                        count = amount / note;
                        amount %= note;
                        break;
                    case 200:
                        count = amount / note;
                        amount %= note;
                        break;
                    case 100:
                        count = amount / note;
                        amount %= note;
                        break;
                }
                if (count > 0)
                {
                    Console.WriteLine($"{note}: {count}");
                }
            }
        }
    }
}