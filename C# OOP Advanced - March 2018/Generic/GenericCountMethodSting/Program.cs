using System;

class Program
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());

        var box = new Box<string>();
        for (int i = 0; i < length; i++)
        {
            var input = Console.ReadLine();
            box.Add(input);
        }

        var compare = Console.ReadLine();

        var n= box.Greaters(box, compare);

        Console.WriteLine(n);
    }
}