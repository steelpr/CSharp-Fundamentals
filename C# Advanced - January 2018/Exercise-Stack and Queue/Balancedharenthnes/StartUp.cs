namespace BalancedParentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            char[] parenthese = Console.ReadLine().ToCharArray();



            string[][] list = new string[3][];

            for (int count = 0; count < parenthese.Length; count++)
            {
                if (parenthese[count] == '{' || parenthese[count] == '}')
                {
                    list[0] = new string[parenthese[count]];
                }
                else if (parenthese[count] == '[' || parenthese[count] == ']')
                {
                    list[1] = new string[parenthese[count]];
                }
                else if (parenthese[count] == '(' || parenthese[count] == ')')
                {
                    list[2] = new string[parenthese[count]];
                }
            }

            for (int row = 0; row < list.Length; row++)
            {
                int count = list[row].Length % 2;
                if (count != 0)
                {
                    Console.WriteLine("NO");
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("YES");
        }
    }
}
