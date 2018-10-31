using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private Tire[] tire;

    public Car(string model,Engine engine, Cargo cargo, Tire[] tireAgeType)
    {
        this.Model = model;
        this.engine = engine;
        this.cargo =cargo;
        this.tire = tireAgeType;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public Engine Engine  => this.engine;
    public Cargo Cargo => cargo;
    public Tire[] Tire => tire;
}

