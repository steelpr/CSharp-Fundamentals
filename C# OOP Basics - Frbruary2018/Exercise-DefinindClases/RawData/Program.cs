using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        List<Car> cars = new List<Car>();

    
        for (int car = 0; car < count; car++)
        {
            string[] input = Console.ReadLine().Split();

            string model = input[0];
            int engineSpeed = int.Parse(input[1]);
            int enginePower = int.Parse(input[2]);
            int cargoWeight = int.Parse(input[3]);
            string cargoType = input[4];

            double tirePressureOne = double.Parse(input[5]);
            int tireAgeOne = int.Parse(input[6]);
            double tirePressureTwo = double.Parse(input[7]);
            int tireAgeTwo = int.Parse(input[8]);
            double tirePressureThree = double.Parse(input[9]);
            int tireAgeThree = int.Parse(input[10]);
            double tirePressureFour = double.Parse(input[11]);
            int tireAgeFour = int.Parse(input[12]);
            Tire[] tire = new Tire[4];
            tire[0] = new Tire(tirePressureOne, tireAgeOne);
            tire[1] = new Tire(tirePressureTwo, tireAgeTwo);
            tire[2] = new Tire(tirePressureThree, tireAgeThree);
            tire[3] = new Tire(tirePressureFour, tireAgeFour);

            Engine engine = new Engine(enginePower, engineSpeed);
            Cargo type = new Cargo(cargoWeight, cargoType);

            Car carData = new Car(model, engine, type, tire);
            cars.Add(carData); 
        }

        string cargo = Console.ReadLine();

        if (cargo == "fragile")
        {
            foreach (var item in cars.Where(c => c.Cargo.CargoType == cargo && c.Tire.Any(t => t.TirePressure < 1)))
            {
                Console.WriteLine(item.Model);
            }
        }
        else if (cargo == "flamable")
        {
            foreach (var item in cars.Where(c => c.Cargo.CargoType == cargo && c.Engine.EnginePower > 250))
            {
                Console.WriteLine(item.Model);
            }
        }
    }
}
