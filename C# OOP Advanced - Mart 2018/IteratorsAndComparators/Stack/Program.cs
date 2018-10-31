using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = string.Empty;

        var stack = new Stack<int>();

        while ((input = Console.ReadLine()) != "END")
        {
            string[] command = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string commands = command[0];

            switch (commands)
            {
                case "Push":
                    for (int i = 1; i < command.Length; i++)
                    {
                        int parse = int.Parse(command[i]);
                        stack.Push(parse);
                    }
                    break;
                case "Pop":
                    stack.Pop();
                    break;
                default:
                    break;
            }
        }

        stack.PrintAll();
    }
}