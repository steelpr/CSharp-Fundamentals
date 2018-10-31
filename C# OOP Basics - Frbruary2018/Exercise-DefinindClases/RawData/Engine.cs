using System;
using System.Collections.Generic;
using System.Text;


public class Engine
{
    private int enginePower;
    private int engineSpeed;

    public Engine(int enginePower, int engineSpeed)
    {
        this.EnginePower = enginePower;
        this.EngineSpeed = engineSpeed;
    }

    public int EnginePower
    {
        get { return enginePower; }
        set { enginePower = value; }
    }

    public int EngineSpeed
    {
        get { return engineSpeed; }
        set { engineSpeed = value; }
    }
}
