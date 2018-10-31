using System;
using System.Collections.Generic;
using System.Text;

namespace BashSoft.Exceptions
{
    class InvalidFileNameException : SystemException
    {
        private const string Forbidden_Symbols_Contained_In_Name = "The given name contains symbols that are not allowed to be used in names of files or folders.";

        public InvalidFileNameException()
            : base(Forbidden_Symbols_Contained_In_Name)
        {
        }

        public InvalidFileNameException(string message)
            : base(message)
        {
        }
    }
}
