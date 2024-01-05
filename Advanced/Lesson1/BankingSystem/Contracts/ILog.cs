using System;

namespace Advanced.Lesson1.BankingSystem.Contracts
{
    public interface ILog
    {
        void Info(string message);
        void Error(string message);
    }
}