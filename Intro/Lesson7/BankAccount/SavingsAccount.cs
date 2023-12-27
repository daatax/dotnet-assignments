using System;

namespace Intro.Lesson7.BankAccount
{
    public class SavingsAccount : BankAccount
    {

        private const double minimumBalance = 100.00;

        public SavingsAccount(string accountNumber, double initialBalance)
            : base(accountNumber, initialBalance) {
        }

        public override void Withdraw(double amount) {
            if (amount <= 0) {
                throw new ArgumentException("Invalid withdrawal amount. Amount should be greater than 0.");
            }
            if (Balance - amount < minimumBalance) {
                throw new ArgumentException("Withdrawal would result in a balance below the minimum threshold of $" + minimumBalance);
            }
            if (amount > Balance) {
                throw new ArgumentException("Insufficient funds for withdrawal.");
            }
            Balance -= amount;
        }
    }
}
