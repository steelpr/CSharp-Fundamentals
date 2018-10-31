using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());


        var box = new Box<int>();
        for (int i = 0; i < length; i++)
        {
            int read = int.Parse(Console.ReadLine());
            box.Add(read);
        }

        int[] indexes = Console.ReadLine()
                        .Split(" ")
                        .Select(int.Parse)
                        .ToArray();

        box.ChandeDigit(box, indexes[0], indexes[1]);

        Console.WriteLine(box);
    }
}