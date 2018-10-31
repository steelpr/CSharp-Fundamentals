namespace CalculateSequenceQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            long sequence = long.Parse(Console.ReadLine());

            Queue calculate = new Queue();
            calculate.Enqueue(sequence);

            List<long> numbers = new List<long>();
            numbers.Add(sequence);

                for (int i = 0; i < 50; i++)
                {
                if (calculate.Count <= 49)
                {
                    long sum = numbers[i] + 1;
                    long secondOperation = 2 * numbers[i] + 1;
                    long thirtoperation = numbers[i] + 2;

                    calculate.Enqueue(sum);
                    calculate.Enqueue(secondOperation);
                    calculate.Enqueue(thirtoperation);

                    numbers.Add(sum);
                    numbers.Add(secondOperation);
                    numbers.Add(thirtoperation);
                }
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(calculate.Dequeue() + " ");
            }
            Console.WriteLine();
        }
    }
}
