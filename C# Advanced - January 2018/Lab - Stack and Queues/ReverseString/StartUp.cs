namespace ReverseString
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> reverse = new Stack<char>(input);

            while (reverse.Count > 0)
            {
                Console.Write(reverse.Pop());
            }
        }
    }
}
