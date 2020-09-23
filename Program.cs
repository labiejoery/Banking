using Banking.Models.Domein;
using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123-45871578-12");
            account.Deposit(200M);
            DisplayBalance(account);
            account.Withdraw(100M);
            DisplayBalance(account);
        }

        private static void DisplayBalance(BankAccount account)
        {
            Console.WriteLine("Balance is " + account.Balance);
        }
    }
}
