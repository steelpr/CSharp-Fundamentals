using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Truck : Vehicles
{
    double DISTANCE = 0;

    public Truck(string model, double fuelQuantity, double literKm, double capacity)
        : base(model, fuelQuantity, literKm, capacity)
    {
    }

    protected override double AirConditionalConsumation => 1.6;

    public override string ToString()
    {
        string basestring = base.ToString();
        return string.Format(basestring, "Truck" , DISTANCE);
    }

    public override void CalculateConsumation(List<Vehicles> vehicles, double distance)
    {
        DISTANCE = distance;
        foreach (var truck in vehicles.Where(t => t is Truck))
        {
            double tank = truck.FuelQuantity;
            double consumation = truck.LiterKilometre;

            double liter = (distance * consumation) + (distance * AirConditionalConsumation);

            if (tank < liter)
            {
                throw new ArgumentException("Truck needs refueling");
            }

            truck.FuelQuantity = tank - liter;
        }
    }

    public override void Refuel(List<Vehicles> vehicles, double distance)
    {
        foreach (var truck in vehicles.Where(t => t is Truck))
        {
            double fuel = (distance * 95) / 100;
            truck.FuelQuantity += fuel;
        }
    }
}
