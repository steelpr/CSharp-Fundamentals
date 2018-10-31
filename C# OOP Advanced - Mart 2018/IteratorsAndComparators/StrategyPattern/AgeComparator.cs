using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class AgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int agePattrern = x.Age.CompareTo(y.Age);

            return agePattrern;
        }
    }
}
