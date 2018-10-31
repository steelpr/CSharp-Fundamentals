using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Car : Vehicles
{
    double DISTANCE = 0;

    public Car(string model, double fuelQuantity, double literKm, double capacity)
        : base(model, fuelQuantity, literKm, capacity)
    {
    }

    protected override double AirConditionalConsumation => 0.9;

    public override string ToString()
    {
        string basestring = base.ToString();
        return string.Format(basestring, "Car", DISTANCE);
    }

    public override void CalculateConsumation(List<Vehicles> vehicles, double distance)
    {
        DISTANCE = distance;
        foreach (var car in vehicles.Where(t => t is Car))
        {
            double tank = car.FuelQuantity;
            double consumation = car.LiterKilometre;

            double liter = (distance * consumation) + (distance * AirConditionalConsumation);

            if (tank < liter)
            {
                throw new ArgumentException("Car needs refueling");
            }

            car.FuelQuantity = tank - liter;
        }
    }

    public override void Refuel(List<Vehicles> vehicles, double distance)
    {
        foreach (var car in vehicles.Where(t => t is Car))
        {
            car.FuelQuantity += distance;
        }
    }
}