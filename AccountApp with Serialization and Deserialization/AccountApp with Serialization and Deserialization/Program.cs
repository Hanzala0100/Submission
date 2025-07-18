namespace AccountApp_with_Serialization_and_Deserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string filePath = @"D:\Swabhav Training\AuroPay\Assignment\AccountApp with Serialization and Deserialization\accountData.txt";
            Account account = null;
            Console.WriteLine("---------------Bank Account with Serialization and Deserialization----------------");

            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    string[] data = System.IO.File.ReadAllLines(filePath);
                    long accNo = long.Parse(data[0]);
                    string name = data[1];
                    string bankName = data[2];
                    double balance = double.Parse(data[3]);
                    account = new Account(accNo, name, bankName, balance);
                    Console.WriteLine("Welcome Back!");
                    Console.WriteLine($"Account Balance: {balance}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading account: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Welcome!!\n Enter Account Details to create new Account\n");
                Console.Write("Enter Account Number: ");
                long accNo = long.Parse(Console.ReadLine());
                Console.Write("Enter Account Holder Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Bank Name: ");
                string bankName = Console.ReadLine();
            wrongInitialBal:
                Console.Write("Enter Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                if (initialBalance < 500)
                {
                    Console.WriteLine("Initial balance must be at least 500.");
                    goto wrongInitialBal;
                }
                account = new Account(accNo, name, bankName, initialBalance);
                Console.WriteLine("\nAccount created successfully!");
            }

            

            bool continueBanking = true;
            while(continueBanking)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amount to deposit: ");
                        double depositAmount = double.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;
                    case 2:
                        Console.Write("Enter amount to withdraw: ");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;
                    case 3:
                        Console.WriteLine($"Current Balance: {account.GetBalance()}");
                        break;
                    case 4:
                        try
                        {
                            System.IO.File.WriteAllLines(filePath, new string[]
                            {
                                account.accountNumber.ToString(),
                                account.accountHolderName,
                                account.bankName,
                                account.balance.ToString()
                            });
                            Console.WriteLine("Account data saved successfully.");
                            continueBanking = false;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error saving account data: {ex.Message}");
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
