namespace BalanceParentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            char[] opening = new[] { '(', '{', '[' };
            char[] closing = new[] { ')', '}', ']' };

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }

            Stack<char> charElement = new Stack<char>();

            foreach (var item in input)
            {
                if (opening.Contains(item))
                {
                    charElement.Push(item);
                }
                else if (closing.Contains(item))
                {
                    char last = charElement.Pop();
                    int index = Array.IndexOf(opening, last);

                    int closeIndex = Array.IndexOf(closing, item);

                    if (index != closeIndex)
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
            if (charElement.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
