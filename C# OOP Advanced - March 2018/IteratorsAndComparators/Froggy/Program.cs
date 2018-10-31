using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] n = Console.ReadLine()
                  .Split(", ")
                  .Select(int.Parse)
                  .ToArray();

        var lake = new Lake(n);


        Console.WriteLine(string.Join(", ", lake));
    }
}
