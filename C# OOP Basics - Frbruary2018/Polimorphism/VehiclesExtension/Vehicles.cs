using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicles
{
    private double fuelQuantity;


    public Vehicles(string model, double fuelQuantity, double literKm, double capacity)
    {
        this.Model = model;
        this.Capacity = capacity;
        this.FuelQuantity = fuelQuantity;
        this.LiterKilometre = literKm;
    }

    protected virtual double AirConditionalConsumation => 1;

    public string Model { get; set; }

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set
        {
            if (value > this.Capacity)
            {
                value = 0;
            }
            fuelQuantity = value;
        }
    }

    public double LiterKilometre { get; set; }
    public double Capacity { get; set; }


    public virtual void CalculateConsumation(List<Vehicles> vehicles, double distance)
    {

    }
    public abstract void Refuel(List<Vehicles> vehicles, double distance);

    public override string ToString()
    {
        return "{0} travelled {1} km";
    }
}