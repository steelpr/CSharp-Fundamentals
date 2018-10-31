using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> personAge = new List<Person>();

        int people = int.Parse(Console.ReadLine());

        for (int i = 0; i < people; i++)
        {
            string[] nameAge = Console.ReadLine().Split();

            string name = nameAge[0];
            int age = int.Parse(nameAge[1]);

            Person person = new Person(name, age);
            personAge.Add(person);
        }

        foreach (var item in personAge.OrderBy(o => o.Name).Where(o => o.Age > 30))
        {
            Console.WriteLine($"{item.Name} - {item.Age}");
        }
    }
}
