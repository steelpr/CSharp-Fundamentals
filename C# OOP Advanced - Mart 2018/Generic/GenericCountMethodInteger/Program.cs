using System;

class Program
{
    static void Main(string[] args)
    {
        var box = new Box<double>();

        int length = int.Parse(Console.ReadLine());

        for (int i = 0; i < length; i++)
        {
            double input = double.Parse(Console.ReadLine());
            box.Add(input);
        }

        double actual = double.Parse(Console.ReadLine());

        double digit = box.Compare(box, actual);

        Console.WriteLine(digit);
    }
}
