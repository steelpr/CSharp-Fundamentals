using System;
using System.Collections.Generic;
using System.Text;

namespace BashSoft.Exceptions
{
    class InvalidNumberOfScoresException : SystemException
    {
        private const string Invalid_Number_Of_Scores = "The number of scores for the given course is greater than the possible.";

        public InvalidNumberOfScoresException()
            : base(Invalid_Number_Of_Scores)
        {
        }

        public InvalidNumberOfScoresException(string message)
            : base(message)
        {
        }
    }
}
