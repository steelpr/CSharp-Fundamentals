using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        string objectData = string.Empty;

        List<Data> birthday = new List<Data>();

        while ((objectData = Console.ReadLine()) != "End")
        {
            string[] animal = objectData.Split();
            string society = animal[0];

            switch (society)
            {
                case "Citizen":
                    string nameCitizen = animal[1];
                    int age = int.Parse(animal[2]);
                    long id = long.Parse(animal[3]);
                    string date = animal[4];
                    Data citizen = new Citizen(nameCitizen, age, id, date);
                    birthday.Add(citizen);
                    break;
                case "Pet":
                    string namePet = animal[1];
                    string birthdayPet = animal[2];
                    Data pet = new Pet(namePet, birthdayPet);
                    birthday.Add(pet);
                    break;
                case "Robot":
                    break;
                default:
                    break;
            }
        }

        string year = Console.ReadLine();

        foreach (var birthdayDate in birthday.Select(c => c.Birthdate))
        {
            var date = birthdayDate.Split('/');

            if (date[2] == year)
            {
                Console.WriteLine(birthdayDate);
            }
        }
    }
}
