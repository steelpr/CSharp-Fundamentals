namespace BasicStackOperation
{
    using System;
    using System.Collections;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int[] operation = Console.ReadLine()
                              .Split(new string[] { " " }, StringSplitOptions.None)
                              .Select(int.Parse)
                              .ToArray();

            int countStack = operation[0];
            int popElement = operation[1];
            int search = operation[2];

            Stack num = new Stack();

            while (num.Count != countStack)
            {
                int[] number = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

                for (int i = 0; i < number.Length; i++)
                {
                    num.Push(number[i]);
                }
            }

            for (int pop = 0; pop < popElement; pop++)
            {
                num.Pop();
            }

            if (num.Contains(search))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(num.Pop());
            }
        }
    }
}
