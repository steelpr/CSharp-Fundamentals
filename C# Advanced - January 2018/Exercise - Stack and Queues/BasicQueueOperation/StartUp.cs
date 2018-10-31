namespace BasicQueueOperation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int firstNum = input[0];
            int secondNum = input[1];
            int thirdNum = input[2];

            Queue<int> digit = new Queue<int>();

            var operand = Console.ReadLine()
                          .Split(' ');

            foreach (var item in operand)
            {
                int parseOperand = int.Parse(item);
                digit.Enqueue(parseOperand);
            }

            for (int i = 0; i < secondNum; i++)
            {
                digit.Dequeue();
            }

            if (digit.Contains(thirdNum))
            {
                Console.WriteLine("true");
            }
            else if (digit.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(digit.Min());
            }
        }
    }
}
