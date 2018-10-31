namespace TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            Queue<int[]> index = new Queue<int[]>();

            int pump = int.Parse(Console.ReadLine());

            for (int i = 0; i < pump; i++)
            {
                int[] petrolPump = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToArray();

                index.Enqueue(petrolPump);
            }

            for (int startIndex = 0; startIndex < pump - 1; startIndex++)
            {
                int indexFuel = 0;
                bool isTrue = true;

                for (int currenIndex = 0; currenIndex < pump; currenIndex++)
                {
                    int[] fuel = index.Dequeue();
                    int currentFuel = fuel[0];
                    int distanceNext = fuel[1];
                    index.Enqueue(fuel);

                    indexFuel += currentFuel - distanceNext;

                    if (indexFuel < 0)
                    {
                        startIndex += currenIndex;
                        isTrue = false;
                        break;
                    }
                }

                if (isTrue)
                {
                    Console.WriteLine(startIndex);
                    Environment.Exit(0);
                }
            }
        }
    }
}
