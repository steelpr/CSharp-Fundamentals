using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    public double Lenght { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public Box(double lenght, double width, double height)
    {
        Lenght = lenght;
        Width = width;
        Height = height;
    }

    public double SurfaceArea(Box box)
    {
        var result = (2 * box.Lenght * box.Width) + (2 * box.Lenght * box.Height) + (2 * box.Width * box.Height);
        return result;
    }

    public double LateralSurfaceArea(Box box)
    {
        var result = (2 * box.Lenght * box.Height) + (2 * box.Width * box.Height);
        return result;
    }

    public double Volume(Box box)
    {
        var result = (box.Width * box.Lenght * box.Height);
        return result;
    }
}