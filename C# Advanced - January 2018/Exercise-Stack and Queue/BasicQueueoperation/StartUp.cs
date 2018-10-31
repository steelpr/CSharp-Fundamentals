namespace BasicQueueOperation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int[] operation = Console.ReadLine()
                              .Split(new string[] { " " }, StringSplitOptions.None)
                              .Select(int.Parse)
                              .ToArray();

            int countQueue = operation[0];
            int dequeueElement = operation[1];
            int look = operation[2];

            Queue<int> element = new Queue<int>();
            int[] copy = new int[] { };

                int[] addNum = Console.ReadLine()
                             .Split(new string[] { " " }, StringSplitOptions.None)
                             .Select(int.Parse)
                             .ToArray();

            for (int i = 0; i < addNum.Length; i++)
            {
                element.Enqueue(addNum[i]);
            }

            for (int i = 0; i < dequeueElement; i++)
            {
                element.Dequeue();
            }

            if(element.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (element.Contains(look))
            {
                Console.WriteLine("true");
            }
            else
            {
                copy = element.ToArray();
                int min = 0;
                for (int i = 0; i < copy.Length - 1; i++)
                {
                    int nums = copy[i];
                    int next = copy[i + 1];
                    if (nums< next)
                    {
                        min = nums;
                    }
                }
                Console.WriteLine(min);
            }
        }
    }
}
