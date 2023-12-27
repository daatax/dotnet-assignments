using System;

namespace Intro.Lesson7.BankAccount
{
    public class BankAccount
    {
        private string accountNumber;
        private double balance;

        public string AccountNumber {
            get { return accountNumber; }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    accountNumber = value;
                }
                else {
                    throw new ArgumentException("The acoount number cannot be null or empty");
                }
            }
        }

        public double Balance {
            get { return balance; }
            set { balance = value; }
        }

        public BankAccount(string accountNumber, double initialBalance) {
            this.accountNumber = accountNumber;
            balance = initialBalance;
        }

        public virtual void Deposit(double amount) {
            if (amount <= 0) {
                throw new ArgumentException("Invalid deposit amount. Amount should be greater than 0.");
            }
            balance += amount;
        }

        public virtual void Withdraw(double amount) {
            if (amount <= 0) {
                throw new ArgumentException("Invalid withdrawal amount. Amount should be greater than 0.");
            }
            if (amount > balance) {
                throw new ArgumentException("Insufficient funds for withdrawal.");
            }
            balance -= amount;
        }
    }
}
