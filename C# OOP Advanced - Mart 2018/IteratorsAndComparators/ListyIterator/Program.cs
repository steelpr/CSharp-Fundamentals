using System;

class Program
{
    static void Main(string[] args)
    {
        string input = string.Empty;

        var listyIterator = new ListyIterator<string>();

        while ((input = Console.ReadLine()) != "END")
        {
            string[] command = input.Split();

            string currentCommand = command[0];

            switch (currentCommand)
            {
                case "Create":
                    if (command.Length > 1)
                    {
                        for (int i = 1; i < command.Length; i++)
                        {
                            listyIterator.Create(command[i]);
                        }
                    }
                    break;
                case "HasNext":
                    Console.WriteLine(listyIterator.HasNext());
                    break;
                case "Print":
                    listyIterator.Print();
                    break;
                case "PrintAll":
                    listyIterator.PrintAll();
                    break;
                case "Move":
                    Console.WriteLine(listyIterator.Move());
                    break;
                default:
                    break;
            }
        }
    }
}