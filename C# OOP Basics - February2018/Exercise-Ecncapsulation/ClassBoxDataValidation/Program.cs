using System;

class Program
{
    static void Main(string[] args)
    {
        double lenght = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double surfaceArea = 0;
        double lateralSurfaceArea = 0;
        double volume = 0;

        try
        {
            Box box = new Box(lenght, width, height);
            surfaceArea = box.SurfaceArea(box);
            lateralSurfaceArea = box.LateralSurfaceArea(box);
            volume = box.Volume(box);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
        }


        Console.WriteLine($"Surface Area - {surfaceArea:f2}");
        Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
        Console.WriteLine($"Volume - {volume:f2}");

    }
}