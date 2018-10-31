using Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models
{
    public class Error : IError
    {
        public Error(DateTime dateTime, string message, ErrorLevel errorLevel)
        {
            this.DateTime = dateTime;
            this.Message = message;
            this.Level = errorLevel;
        }

        public DateTime DateTime { get; } 

        public string Message { get; }

        public ErrorLevel Level { get; }
    }
}
