using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    private string model = "n/a";
    private string power = "n/a";
    private string displacement = "n/a";
    private string efficiency = "n/a";
   
    public Engine()
    {
        this.Model = model;
        this.Power = power;
        this.Displacement = displacement;
        this.Efficiency = efficiency;
    }
    
    public Engine(string model, string power, string displacement, string efficiency)
    {
        this.Model = model;
        this.Power = power;
        this.Displacement = displacement;
        this.Efficiency = efficiency;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Power
    {
        get { return power; }
        set { power = value; }
    }

    public string Displacement
    {
        get { return displacement; }
        set { displacement = value; }
    }

    public string Efficiency
    {
        get { return efficiency; }
        set { efficiency = value; }
    }
}
