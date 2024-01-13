using System;

namespace BankingSystem.Contracts
{
    public interface ILog
    {
        void Info(string message);
        void Error(string message);
    }
}