using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Bus : Vehicles
{
    double DISTANCE = 0;

    public Bus(string model, double fuelQuantity, double literKm, double capacity) 
        : base(model, fuelQuantity, literKm, capacity) {
    }

    protected override double AirConditionalConsumation => 1.4;

    public override void CalculateConsumation(List<Vehicles> vehicles, double distance)
    {
        DISTANCE = distance;
        foreach (var bus in vehicles.Where(t => t is Bus))
        {
            double tank = bus.FuelQuantity;
            double consumation = bus.LiterKilometre;

            double liter = (distance * consumation);

            if (tank < liter)
            {
                throw new ArgumentException("Bus needs refueling");
            }

            bus.FuelQuantity = tank - liter;
        }
    }

    public void CalculateConsumationWithAirCondition(List<Vehicles> vehicles, double distance)
    {
        DISTANCE = distance;
        foreach (var bus in vehicles.Where(t => t is Bus))
        {
            double tank = bus.FuelQuantity;
            double consumation = bus.LiterKilometre;

            double liter = (distance * consumation) + (distance * AirConditionalConsumation);

            if (tank < liter)
            {
                throw new ArgumentException("Bus needs refueling");
            }

            bus.FuelQuantity = tank - liter;
        }
    }

    public override void Refuel(List<Vehicles> vehicles, double distance)
    {
        foreach (var bus in vehicles.Where(t => t is Truck))
        {
            double fuel = (distance * 95) / 100;
            if (distance <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else if (bus.Capacity < fuel)
            {
                throw new ArgumentException($"Cannot fit {distance} fuel in the tank");
            }

            bus.FuelQuantity += fuel;
        }
    }

    public override string ToString()
    {
        string baseString = base.ToString();
        return string.Format(baseString, "Bus", DISTANCE);
    }
}