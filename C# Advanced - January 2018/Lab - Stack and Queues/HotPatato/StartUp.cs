namespace HotPatato
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                             .Split();

            int toss = int.Parse(Console.ReadLine());

            Queue<string> childrenQueue = new Queue<string>(input);

           while(childrenQueue.Count != 1)
            {
                for (int i = 1; i < toss; i++)
                {
                    childrenQueue.Enqueue(childrenQueue.Dequeue());
                }
                Console.WriteLine($"Removed {childrenQueue.Dequeue()}");
            }
            Console.WriteLine($"Last is {childrenQueue.Dequeue()}");
        }
    }
}
