using Advanced.Lesson1.BankingSystem.Contracts;
using Advanced.Lesson1.BankingSystem.Handlers;
using Advanced.Lesson1.BankingSystem.Logger;

namespace Advanced.Lesson1.BankingSystem
{
    public class Program
    {
        public static void Main(string[] args) {
            ILog log = new ConsoleLogger();

            var savingsAccount = new BankAccount(new SavingsAccountHandler(log, "11010110", "savingAccount Holder Name"));
            savingsAccount.Deposit(100);
            savingsAccount.Withdraw(50);
            Console.WriteLine(savingsAccount.GetAccountDetails());

            Console.WriteLine("\n-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");

            var checkingAccount = new BankAccount(new CheckingAccountHandler(log, "10101101", "checkingAccount HolderName", 400));
            checkingAccount.Deposit(500);
            checkingAccount.Withdraw(100);
            Console.WriteLine(checkingAccount.GetAccountDetails());

            Console.WriteLine("\n-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");

            var fixedDepositAccount = new BankAccount(new FixedDepositAcountHandler(log, "1101001", "fixedDepositAccount HolderName", 28));
            fixedDepositAccount.Deposit(100);
            fixedDepositAccount.Withdraw(50);
            Console.WriteLine(fixedDepositAccount.GetAccountDetails());
        }
    }
}
