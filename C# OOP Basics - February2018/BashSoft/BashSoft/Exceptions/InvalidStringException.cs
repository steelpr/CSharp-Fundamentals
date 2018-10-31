using System;
using System.Collections.Generic;
using System.Text;

namespace BashSoft.Exceptions
{
    public class InvalidStringException : Exception
    {
        private const string Null_Or_Empty_Value = "The value of the variable CANNOT be null or empty!";

        public InvalidStringException()
            : base(Null_Or_Empty_Value)
        {
        }

        public InvalidStringException(string message)
            : base(message)
        {
        }
    }
}
