using System;
using System.Collections.Generic;
using System.Text;

public class Bus : Vehicles
{
    public Bus(string model, double fuelQuantity, double literKm, double capacity) 
        : base(model, fuelQuantity, literKm, capacity)
    {
    }

    protected override double AirConditionalConsumation => 1.4;

    public override void CalculateConsumation(List<Vehicles> vehicles, double distance)
    {
        throw new NotImplementedException();
    }

    public override void Refuel(List<Vehicles> vehicles, double distance)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
