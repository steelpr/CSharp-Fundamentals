using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        ICollection<IBuyer> person = new List<IBuyer>();

        int count = int.Parse(Console.ReadLine());

        IBuyer nameBuyer = null;
        for (int i = 0; i < count; i++)
        {
            string[] personName = Console.ReadLine().Split();
            string name = personName[0];

            if (personName.Length == 4)
            {
                nameBuyer = new Citizen(name);
                person.Add(nameBuyer);
            }
            else if (personName.Length == 3)
            {
                nameBuyer = new Rebel(name);
                person.Add(nameBuyer);
            }
        }

        ICollection<string> names = new List<string>();
        string nameQueue = string.Empty;

        while ((nameQueue = Console.ReadLine()) != "End")
        {
            names.Add(nameQueue);
        }

        int sumFood = 0;
        foreach (var trueName in person.Where(n => n is Citizen))
        {
            foreach (var allName in names)
            {
                trueName.BuyFood(allName);
            }
            sumFood  += trueName.Food;
        }

        foreach (var trueName in person.Where(n => n is Rebel))
        {
            foreach (var allName in names)
            {
                trueName.BuyFood(allName);
            }
            sumFood += trueName.Food;
        }

        Console.WriteLine(sumFood);
    }
}
