using System;

class Program
{
    static void Main(string[] args)
    {
        string fisrtDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        var date = DateModifier.Modifier(fisrtDate, secondDate);
        Console.WriteLine(date);
    }
}
