namespace BasicStackOperation
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

            Stack<int> number = new Stack<int>();

            var operand = Console.ReadLine()
                          .Split(' ');

            foreach (var item in operand)
            {
                int parseOperand = int.Parse(item);
                number.Push(parseOperand);
            }

            for (int i = 0; i < secondNum; i++)
            {
                number.Pop();
            }

            if (number.Contains(thirdNum))
            {
                Console.WriteLine("true");
            }
            else if (number.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(number.Pop());
            }
        }
    }
}
