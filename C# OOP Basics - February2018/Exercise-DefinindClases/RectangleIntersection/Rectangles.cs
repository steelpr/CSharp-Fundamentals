using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

public class Rectangles
{
    private string id;
    private int width;
    private int height;
    private int coordinatesOne;
    private int coordinatedTwo;

    public Rectangles()
    {

    }

    public Rectangles(int width, int height, int coordinatesOne, int coordinatedTwo)
    {
        this.Width = width;
        this.Height = height;
        this.CoordinatesOne = coordinatesOne;
        this.CooredinatesTwo = coordinatedTwo;
    }

    public Rectangles(string id, int width, int height, int coordinates1, int coordinates2)
    {
        this.Id = id;
        this.Width = width;
        this.Height = height;
        this.CoordinatesOne = coordinates1;
        this.CooredinatesTwo = coordinates2;
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public int Width
    {
        get { return width; }
        set { width = value; }
    }

    public int Height
    {
        get { return height; }
        set { height = value; }
    }

    public int CoordinatesOne
    {
        get { return coordinatesOne; }
        set { coordinatesOne = value; }
    }

    public int CooredinatesTwo
    {
        get { return coordinatedTwo; }
        set { coordinatedTwo = value; }
    }

    public bool Intersect(Rectangle check1, Rectangle check2)
    {
        var r = Rectangle.Intersect(check1, check2);
        if (check1.IntersectsWith(check2))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
        return true;
    }
}
