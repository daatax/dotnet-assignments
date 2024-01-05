using System;

namespace Advanced.Lesson1.BankingSystem.Contracts
{
    public interface IAccountHandler
    {
        string AccountNumber { get; }
        string HolderName { get; }
        double Balance { get; }
        void Deposit(double amount);
        void Withdraw(double amount);
        string GetAccountDetails();
    }
}
