namespace MaximumElement
{
    using System;
    using System.Collections;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int countStack = int.Parse(Console.ReadLine());

            Stack stack = new Stack();

            object[] copy = new object[] { };
            for (int counter = 0; counter < countStack; counter++)
            {
                int[] addStack = Console.ReadLine()
                                  .Split(new string[] { " " }, StringSplitOptions.None)
                                  .Select(int.Parse)
                                  .ToArray();

                int operation = addStack[0];

                if (addStack.Length > 1 && addStack[0] == 1)
                {
                    stack.Push(addStack[1]);
                }

                switch (operation)
                {
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        int max = 0;
                        for (int i = 0; i < stack.Count; i++)
                        {
                            copy = stack.ToArray();
                            int copyNum = Convert.ToInt32(copy[i]);

                            if (copyNum > max)
                            {
                                max = copyNum;
                            }
                        }
                        Console.WriteLine(max);
                        break;
                }
            }
        }
    }
}
