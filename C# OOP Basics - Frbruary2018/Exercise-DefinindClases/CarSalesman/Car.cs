using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string model = "n/a";
    private Engine power;
    private string weight = "n/a";
    private string color = "n/a";

    public Car()
    {
        this.Model = model;
        this.Weight = weight;
        this.Color = color;
    }

    public Car(string model, string weight, string color)
    {
        this.Model = model;
        this.Weight = weight;
        this.Color = color;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Weight
    {
        get { return weight; }
        set { weight = value; }
    }
    
    public string Color
    {
        get { return color; }
        set { color = value; }
    }
}
