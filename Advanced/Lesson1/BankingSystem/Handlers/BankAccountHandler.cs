using Advanced.Lesson1.BankingSystem.Contracts;

namespace Advanced.Lesson1.BankingSystem
{
    public abstract class BankAccountHandler : IAccountHandler
    {
        private string accountNumber;
        private string holderName;
        private double balance;
        private readonly ILog log;

        public string AccountNumber {
            get { return this.accountNumber; }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    this.accountNumber = value;
                }
                else {
                    throw new InvalidOperationException("The Acoount Number cannot be null or empty!");
                }
            }
        }
        public string HolderName {
            get { return this.holderName; }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    this.holderName = value;
                }
                else {
                    throw new InvalidOperationException("The Holder Name cannot be null or empty!");
                }
            }
        }
        public double Balance {
            get { return this.balance; }
            private set { }
        }

        public BankAccountHandler(ILog log, string accountNumber, string holderName) {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.log = log;
        }

        public abstract string GetAccountDetails();
        public virtual void Deposit(double amount) {
            log.Info($"Trying to deposit {amount} to the account ...");
            if (amount <= 0) {
                log.Error($"Invalid try of deposit. Amount cannot be negative. Deposit amount: {amount}");
                throw new InvalidOperationException("Invalid deposit amount. Amount should be greater than 0.");
            }
            log.Info($"Deposit of {amount} amount is fixed");
            this.balance += amount;
            log.Info($"Deposit of {amount} successfully made. New balance: {this.balance}");
        }

        public virtual void Withdraw(double amount) {
            log.Info($"Trying to withdraw {amount} from the account ...");
            if (amount <= 0) {
                log.Error($"Invalid try of withdrawal. Amount cannot be negative. Withdraw amount: {amount}");
                throw new InvalidOperationException("Invalid withdrawal amount. Amount should be greater than 0.");
            }

            if (amount > this.balance) {
                log.Error($"Insufficient funds for withdrawal. Withdraw amount: {amount}");
                throw new InvalidOperationException("Insufficient funds for withdrawal.");
            }

            this.balance -= amount;
            log.Info($"Withdrawal of {amount} successfully made. New balance: {this.balance}");
        }
    }
}