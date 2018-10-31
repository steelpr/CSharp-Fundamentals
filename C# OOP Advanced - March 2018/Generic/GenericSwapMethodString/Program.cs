using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var box = new Box<string>();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string input = Console.ReadLine();
            box.Add(input);
        }

        int[] index = Console.ReadLine()
                      .Split(" ")
                      .Select(int.Parse)
                      .ToArray();

        box.ChangeValue(box, index[0], index[1]);

        Console.WriteLine(box);
    }
} 
