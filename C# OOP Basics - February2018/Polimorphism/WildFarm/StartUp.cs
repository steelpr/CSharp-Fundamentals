using System;
using System.Collections;
using System.Collections.Generic;

namespace WildFarm
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var animalsCollect = new List<Animal>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] animal = input.Split();
                string type = animal[0];
                string name = animal[1];
                double weight = double.Parse(animal[2]);

                string[] foods = Console.ReadLine().Split();
                string typeFood = foods[0];
                int quantity = int.Parse(foods[1]);

                Animal animals = null;
                switch (type)
                {
                    case "Cat":
                        string livingRegionCat = animal[3];
                        string breedCat = animal[4];
                        animals = new Cat(name, weight, livingRegionCat, breedCat);
                        break;
                    case "Tiger":
                        string livingRegionTiger = animal[3];
                        string breedTiger = animal[4];
                        animals = new Tiger(name, weight, livingRegionTiger, breedTiger);
                        break;
                    case "Dog":
                        string livingRegionDog = animal[3];
                        animals = new Dog(name, weight, livingRegionDog);
                        break;
                    case "Mouse":
                        string livingRegionMouse = animal[3];
                        animals = new Mouse(name, weight, livingRegionMouse);
                        break;
                    case "Hen":
                        double wingSizeHen = double.Parse(animal[3]);
                        animals = new Hen(name, weight, wingSizeHen);
                        break;
                    case "Owl":
                        double wingSizeOwl = double.Parse(animal[3]);
                        animals = new Owl(name, weight, wingSizeOwl);
                        break;
                    default:
                        break;
                }
                Console.WriteLine(animals.Sound());
                animalsCollect.Add(animals);

                Food food = null;
                try
                {
                    switch (typeFood)
                    {
                        case "Vegetable":
                            food = new Vegetable(quantity);
                            break;
                        case "Fruit":
                            food = new Fruit(quantity);
                            break;
                        case "Meat":
                            food = new Meat(quantity);
                            break;
                        case "Seeds":
                            food = new Seeds(quantity);
                            break;
                        default:
                            break;
                    }
                    animals.EatFood(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            foreach (var animal in animalsCollect)
            {
                Console.WriteLine(animal);
            }
        }
    }
}