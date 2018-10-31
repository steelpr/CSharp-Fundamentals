using System;
using System.Collections.Generic;
using System.Linq;

namespace PoisonousPlant
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var index = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .Take(count)
                          .ToArray();


            var days = new int[count];
            var indexes = new Stack<int>();
            indexes.Push(0);

            for (int i = 1; i < index.Length; i++)
            {
                int maxDays = 0;

                while (indexes.Count > 0 && index[indexes.Peek()] >= index[i])
                {
                    maxDays = Math.Max(maxDays, days[indexes.Pop()]);
                }

                if (indexes.Count > 0)
                {
                    days[i] = maxDays + 1;
                }

                indexes.Push(i);
            }

            Console.WriteLine(days.Max());
        }
    }
}
