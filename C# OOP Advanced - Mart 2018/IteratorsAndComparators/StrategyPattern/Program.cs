using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> sortedName = new SortedSet<Person>(new NameComparator());
            SortedSet<Person> sortedAge = new SortedSet<Person>(new AgeComparator());

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] persons = Console.ReadLine().Split();
                string name = persons[0];
                int age = int.Parse(persons[1]);

                Person person = new Person(name, age);

                sortedName.Add(person);
                sortedAge.Add(person);
            }

            Console.WriteLine(string.Join(Environment.NewLine, sortedName));
            Console.WriteLine(string.Join(Environment.NewLine, sortedAge));
        }
    }
}
