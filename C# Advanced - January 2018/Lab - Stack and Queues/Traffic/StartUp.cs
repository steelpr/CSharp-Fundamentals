namespace Traffic
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Queue<string> cars = new Queue<string>();
            int countCars = 0;

            while(input != "end")
            {
                if (input == "green")
                {
                    int carThatCanPass = Math.Min(cars.Count, number);
                    for (int i = 0; i < carThatCanPass; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        countCars++;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{countCars} cars passed the crossroads.");
        }
    }
}
