using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            int result = firstPerson.Name.Length.CompareTo(secondPerson.Name.Length);

            if (result == 0)
            {
                char firstPersonPattern = char.ToLower(firstPerson.Name[0]);
                char secondLetter = char.ToLower(secondPerson.Name[0]);

                result = firstPersonPattern.CompareTo(secondLetter);
            }

            return result;
        }
    }
}
