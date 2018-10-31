using System;
using System.Collections.Generic;
using System.Text;

public class Tire
{
    private double tirePressure;
    private int tireAge;

    public Tire()
    {

    }

    public Tire(double pressure, int age)
    {
        this.TirePressure = pressure;
        this.TireAge = age;
    }

    public double TirePressure
    {
        get { return tirePressure; }
        set { tirePressure = value; }
    }

    public int TireAge
    {
        get { return tireAge; }
        set { tireAge = value; }
    }
}
