using Logger.Models;
using Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ILayout layout = new SimpleLayout();

            IAppender appender = new ConsoleAppender(layout, ErrorLevel.INFO);

            ILogger logger = new Models.Logger(new IAppender[] { appender });

            IError error = new Error(DateTime.Now, "Critical error!", ErrorLevel.CRITICAL);

            logger.Log(error);
            Console.WriteLine(logger.Log(error));
        }
    }
}
