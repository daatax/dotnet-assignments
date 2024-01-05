using Advanced.Lesson1.BankingSystem.Contracts;

namespace Advanced.Lesson1.BankingSystem.Logger
{
    public class ConsoleLogger : ILog
    {
        public void Info(string message) {
            Console.WriteLine($"Info: {message}");
        }
        public void Error(string message) {
            Console.WriteLine($"Error: {message}");
        }
    }
}