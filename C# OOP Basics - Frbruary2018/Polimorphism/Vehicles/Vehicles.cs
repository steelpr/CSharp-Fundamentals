using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicles
{
    public Vehicles(string model, double fuelQuantity, double literKm, double capacity)
    {
        this.Model = model;
        this.FuelQuantity = fuelQuantity;
        this.LiterKilometre = literKm;
        this.Capacity = capacity;
    }

    protected virtual double AirConditionalConsumation => 1;

    public string Model { get; set; }
    public double FuelQuantity { get; set; }
    public double LiterKilometre { get; set; }
    public double Capacity { get; set; }

    public abstract void CalculateConsumation(List<Vehicles> vehicles, double distance);
    public abstract void Refuel(List<Vehicles> vehicles, double distance);

    public override string ToString()
    {
        return "{0} travelled {1} km";
    }
}