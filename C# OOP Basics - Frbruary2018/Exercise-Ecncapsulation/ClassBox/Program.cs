using System;

class Program
{
    static void Main(string[] args)
    {
        double lenght = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        Box box = new Box(lenght, width, height);
        var surfaceArea = box.SurfaceArea(box);
        var lateralSurfaceArea = box.LateralSurfaceArea(box);
        var volume = box.Volume(box);

        Console.WriteLine($"Surface Area - {surfaceArea:f2}");
        Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
        Console.WriteLine($"Volume - {volume:f2}");

    }
}