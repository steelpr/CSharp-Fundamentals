using System;
using System.Collections;
using System.Linq;

namespace Reversenumber
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                          .Split(new string[] { " " }, StringSplitOptions.None)
                          .Select(int.Parse)
                          .ToArray();


            Stack reverse = new Stack();
            for (int count = 0; count < input.Length; count++)
            {
                reverse.Push(input[count]);
            }

            for (int print = 0; print < input.Length; print++)
            {
                Console.Write(reverse.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
