using BankingSystem.Contracts;

namespace BankingSystem.Handlers
{
    public class SavingsAccountHandler : BankAccountHandler
    {
        public SavingsAccountHandler(ILog log, string accountNumber, string holderName)
                : base(log, accountNumber, holderName)
        {
            log.Info($"{this.GetType().Name} has been instantiated");
        }

        public override string GetAccountDetails()
        {
            return $"Account Handler Type: {this.GetType().Name} | Holder Name: {this.HolderName} | " +
                   $"Account Number: {this.AccountNumber} | Current Balance: {this.Balance}";
        }
    }
}