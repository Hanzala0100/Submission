namespace BankGameApp
{
    internal class Program
    {
        public static BankAccount[] bankManager = new BankAccount[2];
        static void Main(string[] args)
        {
            int rounds = 3;

            for (int i = 0; i < bankManager.Length; i++)
            {
                Console.Write("Enter account holder name: ");
                string name = Console.ReadLine();
                Console.Write("Enter account balance: ");
                double balance = double.Parse(Console.ReadLine());

                bankManager[i] = new BankAccount(name, balance);
            }
            Console.WriteLine();

            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine($"Round {i + 1}");
                for (int j = 0; j < bankManager.Length; j++)
                {
                    Console.WriteLine($"Account {bankManager[j].AccountHolder}:");
                    Console.Write("Do you want to Withdraw or Deposit?: ");
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "withdraw")
                    {
                        bankManager[j].Withdraw();
                    }
                    else if (choice == "deposit")
                    {
                        bankManager[j].Deposit();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice!!");
                    }
                }
                Console.WriteLine();
            }
            if (bankManager[0].Balance > bankManager[1].Balance)
            {
                Console.WriteLine($"Account holder {bankManager[0].AccountHolder} has highest balance: {bankManager[0].Balance}");
            }
            else if ((bankManager[0].Balance < bankManager[1].Balance))
            {
                Console.WriteLine($"Account holder {bankManager[1].AccountHolder} has highest balance: {bankManager[1].Balance}");

            }
            else
            {
                Console.WriteLine("Both account holders has same account balance");
            }
        }
    }
}
