using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    private double lenght;

    public double Lenght
    {
        get { return lenght; }
        set
        {
            Validate(value, "Length");
            lenght = value;
        }
    }

    private double width;

    public double Width
    {
        get { return width; }
        set
        {
            Validate(value, "Width");
            width = value;
        }
    }
    private double height;

    public double Height
    {
        get { return height; }
        set
        {
            Validate(value, "Height");
            height = value;
        }
    }


    public Box(double lenght, double width, double height)
    {
        Lenght = lenght;
        Width = width;
        Height = height;
    }

    public void Validate(double value, string size)
    {
        if (value <= 0)
        {
            throw new ArgumentException($"{size} cannot be zero or negative.");
        }
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