using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGameApp
{
    public class BankAccount
    {
        public string AccountHolder;
        public double Balance;

        public BankAccount(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }
        public void Withdraw()
        {
            Console.Write("Enter the amount to withdraw: ");
            double amount = int.Parse(Console.ReadLine());

            if (amount <= Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine($"Your current balance is: {Balance}");
                return;
            }
            Console.WriteLine("Insufficient balance!!");
        }
        public void Deposit()
        {
            Console.Write("Enter the amount to deposit: ");
            double amount = int.Parse(Console.ReadLine());

            Balance = Balance + amount;

            Console.WriteLine($"Your current balance is: {Balance}");
        }
    }
}
