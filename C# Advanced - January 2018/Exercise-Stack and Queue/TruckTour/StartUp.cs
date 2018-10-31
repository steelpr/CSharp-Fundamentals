namespace TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int pump = int.Parse(Console.ReadLine());


            Queue<int[]> petrol = new Queue<int[]>();
            for (int i = 0; i < pump; i++)
            {
                int[] pumpDistance = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();

                petrol.Enqueue(pumpDistance);
            }


            for (int i = 0; i <= petrol.Count - 1; i++)
            {
                int fuel = 0;
                bool havePetrol = true;
                for (int petrolP = 0; petrolP < petrol.Count; petrolP++)
                {
                    int[] literAndDistance = petrol.Dequeue();

                    int liter = literAndDistance[0];
                    int distance = literAndDistance[1];
                    petrol.Enqueue(literAndDistance);


                    fuel += liter - distance;
                    if (fuel < 0)
                    {
                        i += petrolP;
                        havePetrol = false;
                        break;
                    }
                }
                if (havePetrol)
                {
                    Console.WriteLine(i);
                    Environment.Exit(0);
                }
            }
        }
    }
}
