using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {

        var family = new Family();
        var numberOfPersons = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPersons; i++)
        {
            var personInfo = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var person = new Person(personInfo[0], int.Parse(personInfo[1]));
            family.AddMember(person);
        }

        var oldestMember = family.GetOldestMember();

        if (oldestMember != null)
        {
            Console.WriteLine($"{(oldestMember.Name).ToString()} {(oldestMember.Age).ToString()}");
        }
    }
}
