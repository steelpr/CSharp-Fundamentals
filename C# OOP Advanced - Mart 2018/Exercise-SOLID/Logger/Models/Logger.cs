using Logger.Models.Contracts;
using System.Collections.Generic;

namespace Logger.Models
{
    public class Logger : ILogger
    {
        IEnumerable<IAppender> appenders;

        public Logger(IEnumerable<IAppender> appenders)
        {
            this.appenders = appenders;
        }

        public void Log(IError error)
        {
            foreach (var appender in this.appenders)
            {
                if (appender.Level <= error.Level)
                {
                    appender.Append(error);
                }
            }
        }
    }
}
