using Advanced.Lesson1.BankingSystem.Contracts;

namespace Advanced.Lesson1.BankingSystem.Handlers
{
    public class FixedDepositAcountHandler : BankAccountHandler
    {
        private readonly int age;
        public FixedDepositAcountHandler(ILog log, string accountNumber, string holderName, int age)
                : base(log, accountNumber, holderName) {
            this.age = age;
            log.Info($"{this.GetType().Name} has been instantiated");
        }

        public override void Deposit(double amount) {
            if (age >= 18) {
                base.Deposit(amount);
            }
            else {
                throw new InvalidOperationException("Must be 18 or older to make a deposit.");
            }
        }

        public override string GetAccountDetails() {
            return $"Account Handler Type: {this.GetType().Name} | Holder Name: {this.HolderName} | " +
                   $"Account Number: {this.AccountNumber} | Current Balance: {this.Balance} | Holder Age: {this.age}";
        }
    }
}
