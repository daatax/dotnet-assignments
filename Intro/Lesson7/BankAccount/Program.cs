using System;
using System.Xml.Linq;

namespace Intro.Lesson7.BankAccount
{
    public class Program
    {
        public static void Main(string[] args) {
            SavingsAccount savingsAccount = new SavingsAccount("247129910009", 940);
            CheckingAccount checkingAccount = new CheckingAccount("15100290221", 602);

            Console.WriteLine("The account number of the Savings account is: " + savingsAccount.AccountNumber);
            Console.WriteLine("The initial balance in the Savings Account is: " + savingsAccount.Balance + "\n");

            Console.WriteLine("The account number of the Checking account is: " + checkingAccount.AccountNumber);
            Console.WriteLine("The initial balance in the Checking Account is: " + checkingAccount.Balance + "\n");

            try {
                Console.WriteLine("Deposit to Savings Account ... ");
                savingsAccount.Deposit(230);
                Console.WriteLine("Current Savings balance is: " + savingsAccount.Balance + "\n");

                Console.WriteLine("Deposit to Checkings Account ... ");
                checkingAccount.Deposit(110);
                Console.WriteLine("Current Checkings balance is: " + checkingAccount.Balance + "\n");

                Console.WriteLine("Withdraw from the Savings Account ... ");
                savingsAccount.Withdraw(805);
                Console.WriteLine("Current Savings balance is: " + savingsAccount.Balance + "\n");

                Console.WriteLine("Withdraw from the Checkings Account ... ");
                checkingAccount.Withdraw(503);
                Console.WriteLine("Current Checkings balance is: " + checkingAccount.Balance);
            }
            catch (ArgumentException ae) {
                Console.WriteLine("Error: " + ae.Message);
            }
        }
    }
}
