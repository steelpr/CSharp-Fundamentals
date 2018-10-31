namespace MatchingBrackets
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> bracketsIndex = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    bracketsIndex.Push(i);
                }
                else if (input[i] == ')')
                {
                    int openBrackets = bracketsIndex.Pop();
                    int length = i - openBrackets + 1;
                    Console.WriteLine(input.Substring(openBrackets, length));
                }
            }
        }
    }
}
