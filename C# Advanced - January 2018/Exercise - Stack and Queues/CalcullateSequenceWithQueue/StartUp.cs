namespace CalcullateSequenceWithQueue
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());


            Queue<long> digit = new Queue<long>();
            Queue<long> queue = new Queue<long>();

            digit.Enqueue(number);
            queue.Enqueue(number);

            long newNum = number;

            while (digit.Count < 50)
            {
                long n = queue.Dequeue();
                long sum = n + 1;
                long multiplication = 2 * n + 1;
                long lastOperation = n + 2;

                digit.Enqueue(sum);
                digit.Enqueue(multiplication);
                digit.Enqueue(lastOperation);

                queue.Enqueue(sum);
                queue.Enqueue(multiplication);
                queue.Enqueue(lastOperation);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{digit.Dequeue()} ");
            }
        }
    }
}
