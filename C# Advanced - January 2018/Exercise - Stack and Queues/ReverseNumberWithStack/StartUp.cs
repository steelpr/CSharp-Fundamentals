using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumberWithStack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                           .Split(' ');

            Stack<string> reverse = new Stack<string>(input);

            foreach (var item in reverse)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
