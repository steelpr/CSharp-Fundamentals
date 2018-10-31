using System;
using System.Collections.Generic;
using System.Linq;

namespace PetClinic
{
    class Program
    {
        static void Main(string[] args)
        {
            var pet = new List<Pet>();
            var clinic = new List<Clinic>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];
                try
                {
                    switch (command)
                    {
                        case "Create":
                            if (input[1] == "Pet")
                            {
                                string name = input[2];
                                int age = int.Parse(input[3]);
                                string kind = input[4];
                                Pet newPet = new Pet(name, age, kind);
                                pet.Add(newPet);
                            }
                            else if (input[1] == "Clinic")
                            {
                                string name = input[2];
                                int room = 0;
                                Clinic clinics = null;
                                if (input.Length > 3)
                                {
                                    room = int.Parse(input[3]);
                                    clinics = new Clinic(name, room);
                                    clinic.Add(clinics);
                                }
                            }
                            break;
                        case "Release":
                            Clinic pets = clinic.FirstOrDefault(n => n.Name == input[1]);
                            Console.WriteLine(pets.Release());
                            break;
                        case "Add":
                            Pet animal = pet.FirstOrDefault(p => p.Name == input[1]);
                            Clinic animalClinic = clinic.FirstOrDefault(p => p.Name == input[2]);
                            Console.WriteLine(animalClinic.Add(animal));
                            break;
                        case "HasEmptyRooms":
                            Clinic animalC = clinic.FirstOrDefault(n => n.Name == input[1]);
                            Console.WriteLine(animalC.HasEmptyRooms);
                            break;
                        case "Print":
                            Clinic petsClin = clinic.FirstOrDefault(n => n.Name == input[1]);
                            if (input.Length == 3)
                            {
                                int room = int.Parse(input[2]);
                                Console.WriteLine(petsClin.Print(room));
                            }
                            else
                            {
                                Console.WriteLine(petsClin.PrintAll());
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
