using System;
using System.Collections.Generic;
using System.Text;

namespace BashSoft.Exceptions
{
    class DuplicateEntryInStructureException : SystemException
    {
        private const string Duplicate_Entry = "The {0} already exists in {1}.";

        public DuplicateEntryInStructureException(string message)
            : base(message)
        {
        }

        public DuplicateEntryInStructureException(string entry, string structure)
            : base(string.Format(Duplicate_Entry, entry, structure))
        {
        }
    }
}
