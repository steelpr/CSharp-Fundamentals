using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();

            maxStack.Push(int.MinValue);

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

                switch (input[0])
                {
                    case 1:
                        var element = input[1];
                        stack.Push(element);

                        if (element >= maxStack.Peek())
                        {
                            maxStack.Push(element);
                        }
                        break;
                    case 2:
                        var poppedElement = stack.Pop();

                        if (maxStack.Peek() == poppedElement)
                        {
                            maxStack.Pop();
                        }
                        break;
                    case 3:
                        Console.WriteLine(maxStack.Peek());
                        break;
                }
            }
        }
    }
}
