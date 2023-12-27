using System;

namespace Intro.Lesson7.BankAccount
{
    public class CheckingAccount : BankAccount
    {
        private const double withdrawlFee = 5.0;

        public CheckingAccount(string accountNumber, double initialBalance)
            : base(accountNumber, initialBalance) {
        }

        public override void Withdraw(double amount) {
            if (amount <= 0) {
                throw new ArgumentException("Invalid withdrawal amount. Amount should be greater than 0.");
            }
            if (Balance - amount - withdrawlFee < 0 || amount > Balance) {
                throw new ArgumentException("Insufficient funds for withdrawal.");
            }
            Balance -= amount;
        }
    }
}
