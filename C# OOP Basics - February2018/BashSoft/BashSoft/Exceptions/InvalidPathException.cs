using System;
using System.Collections.Generic;
using System.Text;

namespace BashSoft.Exceptions
{
    class InvalidPathException : SystemException
    {
        private const string Invalid_Path = "The source does not exist.";

        public InvalidPathException()
            : base(Invalid_Path)
        {
        }

        public InvalidPathException(string message)
            : base(message)
        {
        }
    }
}
