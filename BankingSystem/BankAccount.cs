using BankingSystem.Contracts;

namespace BankingSystem
{
    public class BankAccount
    {
        private readonly IAccountHandler accountHandler;

        public BankAccount(IAccountHandler account)
        {
            this.accountHandler = account;
        }

        public void Deposit(double amount)
        {
            accountHandler.Deposit(amount);
        }
        public void Withdraw(double amount)
        {
            accountHandler.Withdraw(amount);
        }
        public string GetAccountDetails()
        {
            return accountHandler.GetAccountDetails();
        }
    }
}