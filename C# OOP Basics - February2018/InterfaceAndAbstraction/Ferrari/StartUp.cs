using System;
using System.Text.RegularExpressions;

class StartUp
{
    static void Main(string[] args)
    {
        string driver = Console.ReadLine();

        ICar car = new Ferrari();

        Console.WriteLine($"{car.Model}/{car.Brakes}/{car.GasPedal}/{driver}");
    }
}
