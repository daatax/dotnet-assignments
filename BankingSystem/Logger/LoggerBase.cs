using BankingSystem.Contracts;

namespace BankingSystem.Logger
{
    public class LoggerBase : ILog
    {
        private readonly ILog log;
        public LoggerBase(ILog log)
        {
            this.log = log;
        }

        public void Error(string message)
        {
            log.Error(message);
        }
        public void Info(string message)
        {
            log.Info(message);
        }
    }
}
