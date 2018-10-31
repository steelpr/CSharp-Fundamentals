using System;
using System.Collections.Generic;
using System.Text;


public class Cargo
{
    private int cargoWeight;
    private string cragoType;

    public Cargo(int cargoWeight, string cargoType)
    {
        this.CargoWeight = cargoWeight;
        this.CargoType = cargoType;
    }

    public int CargoWeight
    {
        get { return cargoWeight; }
        set { cargoWeight = value; }
    }

    public string CargoType
    {
        get { return cragoType; }
        set { cragoType = value; }
    }

}
