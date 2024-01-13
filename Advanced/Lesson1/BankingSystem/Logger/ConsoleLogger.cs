using BankingSystem.Contracts;

namespace BankingSystem.Logger
{
    public class ConsoleLogger : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine($"Info: {message}");
        }
        public void Error(string message)
        {
            Console.WriteLine($"Error: {message}");
        }
    }
}