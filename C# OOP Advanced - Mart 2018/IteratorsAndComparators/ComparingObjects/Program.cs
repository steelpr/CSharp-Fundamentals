using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string peopleData = string.Empty;

            while ((peopleData = Console.ReadLine()) != "END")
            {
                string[] persons = peopleData.Split();

                string name = persons[0];
                int age = int.Parse(persons[1]);
                string town = persons[2];

                Person person = new Person(name, age, town);
                people.Add(person);
            }

            int index = int.Parse(Console.ReadLine());
            var personCompare = people[index - 1];

            int matches = 0;

            foreach (Person item in people)
            {
                if (item.CompareTo(personCompare) == 0)
                {
                    matches++;
                }
            }

            if (matches <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {people.Count - matches} {people.Count}");
            }
        }
    }
}
