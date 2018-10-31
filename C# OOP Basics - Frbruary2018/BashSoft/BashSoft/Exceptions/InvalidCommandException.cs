using System;
using System.Collections.Generic;
using System.Text;

namespace BashSoft.Exceptions
{
    public class InvalidCommandException : Exception
    {
        private const string Invalid_Command = "The command '{0}' is invalid";

        public InvalidCommandException(string message)
            : base(string.Format(Invalid_Command, message))
        {
        }
    }
}
