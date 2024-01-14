using BankingSystem.Contracts;

namespace BankingSystem.Handlers
{
    public class CheckingAccountHandler : BankAccountHandler
    {
        private readonly double overdraftLimit;
        public CheckingAccountHandler(ILog log, string accountNumber, string holderName, double overdraftLimit)
                : base(log, accountNumber, holderName)
        {
            this.overdraftLimit = overdraftLimit;
            log.Info($"{this.GetType().Name} has been instantiated");
        }

        public override void Withdraw(double amount)
        {
            if (Math.Abs(amount - overdraftLimit) < Math.Abs(Balance)) {
                base.Withdraw(amount);
            }
            else {
                throw new InvalidOperationException("Withdrawal amount exceeds available overdraft limit.");
            }
        }

        public override string GetAccountDetails()
        {
            return $"Account Handler Type: {this.GetType().Name} | Holder Name: {this.HolderName} | " +
                   $"Account Number: {this.AccountNumber} | Current Balance: {this.Balance} | Overdraft Limit: {this.overdraftLimit}";
        }
    }
}
