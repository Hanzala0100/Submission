using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp_with_Serialization_and_Deserialization
{
    internal class Account
    {
        public long accountNumber;
        public string accountHolderName;
        public string bankName;
        public double balance;

        public Account(long accNo, string name, string bankName, double balance)
        {
            this.accountNumber = accNo;
            this.accountHolderName = name;
            this.bankName = bankName;
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}. New Balance: {balance}");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }

        public double GetBalance()
        {
            return balance;
        }

        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(accountNumber);
                writer.WriteLine(accountHolderName);
                writer.WriteLine(bankName);
                writer.WriteLine(balance);
            }
        }

        public static Account LoadFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                long accNo = long.Parse(reader.ReadLine());
                string name = reader.ReadLine();
                string bankName = reader.ReadLine();
                double balance = double.Parse(reader.ReadLine());
                return new Account(accNo, name, bankName, balance);
            }
        }

    }
}
